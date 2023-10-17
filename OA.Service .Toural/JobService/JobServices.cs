using AutoMapper;
using ClosedXML.Excel;
using OA.Common.Utility;
using OA.Data.Toural.Cost;
using OA.Data.Toural.Job;
using OA.Repo.Troual.Contracts.Job;
using OA.Service_.Toural.Contracts.JobService;
using OA.Service_.Toural.ViewModels.Cost;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.Job;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.JobService
{
    public class JobServices : IJobServices
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;
        private readonly ICostJobRepository _costJobRepository;
        private readonly IInitialBalanceJobRepository _initialBalanceJobRepository;
        public JobServices(IJobRepository jobRepository,
                         ICostJobRepository costJobRepository,
                         IMapper mapper,
                           IInitialBalanceJobRepository initialBalanceJobRepository)
        {
            this._jobRepository = jobRepository;
            this._costJobRepository = costJobRepository;
            this._initialBalanceJobRepository = initialBalanceJobRepository;
            this._mapper = mapper;
        }

        public ExcelDto GetJob(string ID)
        {
            var entity = _jobRepository.Get(ID);
            var result = new ExcelDto();
            try
            {
                var intialBalanceEntities = entity.InitialBalanceJobEntities;
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string fileName = "Cost.xlsx";
                using (var workbook = new XLWorkbook())
                {
                    workbook.RightToLeft = true;
                    IXLWorksheet worksheet = workbook.Worksheets.Add("محصولات");
                    worksheet.Cell(1, 1).Value = "شناسه محصول";
                    worksheet.Cell(1, 2).Value = "قیمت قبل از سرشکن هزینه";
                    worksheet.Cell(1, 3).Value = "قیمت بعد از سرشکن";
                    worksheet.Cell(1, 4).Value = " ارزش وزنی محصول در سرشکن";
                    worksheet.Cell(1, 5).Value = "هزینه کل جاری";
                    worksheet.Cell(1, 6).Value = "درصد سرشکن هزینه";
                    worksheet.Cell(1, 7).Value = "قیمت بعد از سرشکن ماهیانه";
                    worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 2).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 3).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 4).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 5).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 6).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 7).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    IXLRange range = worksheet.Range(worksheet.Cell(1, 1).Address, worksheet.Cell(1, 8).Address);
                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;

                    for (int index = 1; index <= intialBalanceEntities.Count; index++)
                    {
                        worksheet.Cell(index + 1, 1).Value = intialBalanceEntities[index - 1].InitialBalanceEntity.Id;
                        worksheet.Cell(index + 1, 2).Value = intialBalanceEntities[index - 1].PriceBeforeCalculation;
                        worksheet.Cell(index + 1, 3).Value = intialBalanceEntities[index - 1].NewPrice;
                        worksheet.Cell(index + 1, 4).Value = intialBalanceEntities[index - 1].WeightProductInCalculation;
                        worksheet.Cell(index + 1, 5).Value = intialBalanceEntities[index - 1].TotalPriceProducts;
                        worksheet.Cell(index + 1, 6).Value = entity.WeightInCalculation;
                        worksheet.Cell(index + 1, 7).Value = (entity.WeightInCalculation* intialBalanceEntities[index - 1].NewPrice)+ intialBalanceEntities[index - 1].NewPrice;
                        worksheet.Range(worksheet.Cell(index + 1, 1).Address, worksheet.Cell(index + 1, 8).Address);
                        worksheet.Columns().AdjustToContents();

                    }
                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        result.Content = content;
                        result.contentType = contentType;
                        result.fileName = fileName;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public JobVM GetJobs()
        {
            var result = new JobVM();
            var data = _jobRepository.GetALL();
            result.jobDtos = _mapper.Map<List<JobEntities>, List<JobDto>>(data);
            result.numberRows = data.Count;
            return result;
        }

        public JobVM GetPrevMonthJob(DateTime startMiladiDate,DateTime endMiladiDate)
        {
            var result = new JobVM();
            var data = _jobRepository.GetQueryData(z => z.ExecutedDate >= startMiladiDate && z.ExecutedDate <= endMiladiDate).FirstOrDefault();
            if (data == null)
                return null;
            result.jobDto = _mapper.Map<JobEntities, JobDto>(data);
            return result;
        }

        public decimal? GetPrevMonthJob(DateTime startMiladiDate, DateTime endMiladiDate, long currentMonthCost,long totalPriceBalanceCurrentMonth)
        {
            var result = new JobVM();
            var data = _jobRepository.GetQueryData(z => z.ExecutedDate >= startMiladiDate && z.ExecutedDate <= endMiladiDate).FirstOrDefault();
            var prevMonthTotalCost = data.InitialBalanceJobEntities.FirstOrDefault().InitialBalanceEntity.TotalCostPrice;
            var prevTotalBalanceCost = data.InitialBalanceJobEntities.FirstOrDefault().InitialBalanceEntity.TotalPriceBalanceLastMonth+ totalPriceBalanceCurrentMonth;
            currentMonthCost = long.Parse(prevMonthTotalCost.ToString()) + currentMonthCost;
            var currentWeightCalculation = Decimal.Round(currentMonthCost / prevTotalBalanceCost,5,MidpointRounding.AwayFromZero);
            return currentWeightCalculation;
        }

        public void SaveJob(List<CostEntity> costEntities, List<InitialBalancePoco> initialBalanceDtos,Decimal WeightInCalculation)
        {
            JobEntities job = new JobEntities();
            job.ExecutedDate = DateTime.Now;
            job.TotalCost = costEntities.Sum(z => z.CostAmount);
            job.CostJobEntities = new List<CostJobEntity>();
            job.WeightInCalculation = WeightInCalculation;
            foreach (var costEntity in costEntities)
            {
                job.CostJobEntities.Add(new CostJobEntity
                {
                    ID = Guid.NewGuid().ToString(),
                    CostEntityID = costEntity.Id,
                    MonthDuration = (costEntity.RemainingMonth+1) - costEntity.RemainingMonth,
                });
            }
            job.InitialBalanceJobEntities = new List<InitialBalanceJobEntity>();
            foreach (var product in initialBalanceDtos)
            {
                job.InitialBalanceJobEntities.Add(new InitialBalanceJobEntity
                {
                    ID = Guid.NewGuid().ToString(),
                    InitialBalanceEntityID = product.ID,
                    NewPrice = product.Price,
                    PriceBeforeCalculation = product.PriceBeforeCalculation,
                    WeightProductInCalculation = product.WeighProductInCalculation,
                    TotalPriceProducts = initialBalanceDtos.Sum(z=>z.PriceBeforeCalculation)
                });
            }
            _jobRepository.Insert(job);
            _jobRepository.SaveChanges();
        }
    }
}
