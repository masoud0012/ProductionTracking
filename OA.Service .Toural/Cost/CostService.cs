using AutoMapper;
using ClosedXML.Excel;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.Cost;
using OA.Repo.Troual.Contracts;
using OA.Repo.Troual.Contracts.ICost;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.Contracts.JobService;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.ViewModels.Cost;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Cost
{
    public class CostService : ICostService
    {
        private readonly IMapper _mapper;
        private readonly ICostRepository _repository;
        public readonly ICostCategoryService _costCategoryService;
        public readonly IInitialBalanceService _initialBalanceService;
        private readonly IJobServices _jobServices;
        private readonly IJWService _jwtService;

        public CostService(ICostRepository repository,
            IInitialBalanceService initialBalanceService,

            IJWService jwtService,
            IJobServices jobServices,
            ICostCategoryService costCategoryService,
                                IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._costCategoryService = costCategoryService;
            this._initialBalanceService = initialBalanceService;
            this._jobServices = jobServices;
            this._jwtService = jwtService;

        }



        public CostVM Edit(CostDto body)
        {

            var result = new CostVM();
            try
            {

                var entity = _repository.Get(body.ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                if (_repository.GetQuery(z => z.Title == body.Title && z.Id != body.ID && z.IsEnabled == true) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                var costCategoryItem = _costCategoryService.GetByID(body.costCategoryDto.ID);
                if (costCategoryItem.hasError == true)
                    throw new CustomErrorException(costCategoryItem.ErrorMessage, costCategoryItem.Code);
                if (body.CostAmount <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                entity.ModifiedById = this._jwtService.GetUserID();
                entity.CostAmount = body.CostAmount;
                entity.CostDate = DateTime.Parse(body.CostDate);
                entity.CostCategoryID = costCategoryItem.costCategoryDto.ID;
                entity.Title = body.Title;
                entity.Month = body.Month;
                entity.Description = body.Description;
                entity.ModifiedDate = DateTime.Now;
                entity.RemainingMonth = body.Month;
                _repository.Update(entity);
                _repository.SaveChanges();

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM GetByID(long ID)
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.Get(ID);
                result.costDto = _mapper.Map<CostEntity, CostDto>(entity);
                result.costDto.costCategoryDto = _mapper.Map<CostCategoryEntity, CostCategoryDto>(entity.CostCategory);

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public CostVM Remove(long[] id)
        {
            var result = new CostVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = _repository.Get(item);
                    entity.ModifiedById = this._jwtService.GetUserID();
                    entity.IsEnabled = false;
                }
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM Search(CostDto body)
        {
            var result = new CostVM();
            try
            {

                if (body.Row <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);

                var expression = query(z => (
                    (string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                        string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                            string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &
                                    z.IsEnabled == true);

                var queryResult = _repository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _repository.GetQuery(expression);

                result.costDtos = _mapper.Map<List<CostEntity>, List<CostDto>>(queryResult);
                result.numberRows = countTable;
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private Expression<Func<CostEntity, bool>> query(Expression<Func<CostEntity, bool>> expression)
        {
            return expression;
        }

        public CostVM Insert(CostDto body)
        {
            var result = new CostVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (string.IsNullOrEmpty(body.CostDate))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (_repository.GetQuery(z => z.Title == body.Title && z.IsEnabled == true) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                if (body.costCategoryDto == null)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                if (body.Month <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                var costCategoryItem = _costCategoryService.GetByID(body.costCategoryDto.ID);
                if (costCategoryItem.hasError == true)
                    throw new CustomErrorException(costCategoryItem.ErrorMessage, costCategoryItem.Code);
                var entity = new CostEntity();
                entity.CostDate = DateTime.Parse(body.CostDate);
                entity.CostAmount = body.CostAmount;
                entity.CreatedById = this._jwtService.GetUserID();
                entity.Month = body.Month;
                entity.CostCategoryID = costCategoryItem.costCategoryDto.ID;
                entity.Description = body.Description;
                entity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.Cost) + _repository.LastInsertedID();
                entity.Title = body.Title;
                entity.AddedDate = DateTime.Now;
                entity.RemainingMonth = body.Month;
                _repository.Insert(entity);
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM GetAll()
        {
            var result = new CostVM();
            try
            {
                result.costDtos =
                    _mapper.Map<List<CostEntity>, List<CostDto>>(_repository.GetALL());
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM Remove(long id)
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.Get(id);
                entity.IsEnabled = false;
                entity.ModifiedById = this._jwtService.GetUserID();
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM Active(long id)
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.GetQuery(z => z.Id == id, 1, 1, string.Empty).FirstOrDefault();
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.IsEnabled = true;
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }


        public DateTime ConvertPersianDateToGregorianDate(int year, int month, int day)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(year, month, day, pc);
            return dt;
        }


        public CostVM CalculateCostPerMonth()
        {
            if (PersianDateTime.Now.Day == 1)//در صورتی که اول ماه جدید شمسی باشد ، جاب اجرا می گردد.
            {
                var prevShamsiMonth = PersianDateTime.Now.Month-1;
                if (PersianDateTime.Now.Month == 1)
                    prevShamsiMonth = 12;

                var currentDaysOfMonth = PersianDateTime.GetDaysInMonth(PersianDateTime.Now.Year, prevShamsiMonth);
                var startMiladiDate = ConvertPersianDateToGregorianDate(PersianDateTime.Now.Year,prevShamsiMonth,1);
                var endMiladiDate = ConvertPersianDateToGregorianDate(PersianDateTime.Now.Year,prevShamsiMonth,currentDaysOfMonth);
                //در اینجا روز اول ماه قبل با روز آخر ماه قبل به دست می آید.

                var currentMonthCosts = _repository.GetQueryData(startMiladiDate, endMiladiDate);//لیست تمام هزینه های ماه قبل

                var totalCostOfCurrentMonth = currentMonthCosts.Sum(z => z.CostAmount / z.Month);

                var result = _initialBalanceService.CalculateProducts(startMiladiDate, endMiladiDate, totalCostOfCurrentMonth);
                if (result.hasError == false)
                {
                    foreach (var item in currentMonthCosts)
                    {
                        item.RemainingMonth = item.RemainingMonth - 1;
                        item.CalculationDate = DateTime.Now;

                    }
                }
                _repository.SaveChanges();

                _jobServices.SaveJob(currentMonthCosts, result.initialBalanceDtos,result.initialBalanceDto.WeightInCalculation);//ذخیره عملیات انجام شده توسط جاب
            }

            return null;
        }

        public ExcelDto PrintExcel()
        {
            var result = new ExcelDto();
            try
            {
                var costsEntities = _repository.GetALL();
               var costDtos =
                    _mapper.Map<List<CostEntity>, List<CostDto>>(costsEntities);
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string fileName = "Cost.xlsx";
                using (var workbook = new XLWorkbook())
                {
                    workbook.RightToLeft = true;
                    IXLWorksheet worksheet =workbook.Worksheets.Add("هزینه ها");
                    worksheet.Cell(1, 1).Value = "شناسه";
                    worksheet.Cell(1, 2).Value = "کد";
                    worksheet.Cell(1, 3).Value = "سرفصل هزینه";
                    worksheet.Cell(1, 4).Value = "توضیحات";
                    worksheet.Cell(1, 5).Value = "تاریخ هزینه";
                    worksheet.Cell(1, 6).Value = "مبلغ هزینه";
                    worksheet.Cell(1, 7).Value = "دوره هزینه(ماه)";
                    worksheet.Cell(1, 8).Value = "تاریخ ایجاد";

                    worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 2).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 3).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 4).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 5).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 6).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 7).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 8).Style.Fill.SetBackgroundColor(XLColor.Cyan);

                    IXLRange range = worksheet.Range(worksheet.Cell(1, 1).Address, worksheet.Cell(1, 8).Address);
                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;

                    for (int index = 1; index <= costDtos.Count; index++)
                    {
                        worksheet.Cell(index + 1, 1).Value =costDtos[index - 1].ID;
                        worksheet.Cell(index + 1, 2).Value =costDtos[index - 1].Code;
                        worksheet.Cell(index + 1, 3).Value = costsEntities.FirstOrDefault(z=>z.Id== costDtos[index - 1].ID).Title;
                        worksheet.Cell(index + 1, 4).Value =costDtos[index - 1].Description;
                        worksheet.Cell(index + 1, 5).Value =costDtos[index - 1].CostDate;
                        worksheet.Cell(index + 1, 6).Value = costDtos[index - 1].CostAmount;
                        worksheet.Cell(index + 1, 7).Value = costDtos[index - 1].Month;
                        worksheet.Cell(index + 1, 8).Value = costDtos[index - 1].createdDate;
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

        public CostVM GetAllCosts()
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.GetCosts();
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                result.costDtos = _mapper.Map<List<CostEntity>, List<CostDto>>(entity);
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM GetAllCosts(DateTime StartMiladiDate, DateTime EndMiladiDate)
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.GetQueryData(StartMiladiDate,EndMiladiDate);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                result.costDtos = _mapper.Map<List<CostEntity>, List<CostDto>>(entity);
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
