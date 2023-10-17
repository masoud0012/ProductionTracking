using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IProcess;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Process
{
    public class ProcessBalanceService : IProcessBalanceService
    {
        private readonly IMapper _mapper;
        private readonly IProcessBalanceRepository _repository;
        private readonly IProcessService _processService;
        private readonly IStockRoom_InitialBalanceRepository _stockRoom_InitialBalanceRepository;
        private readonly IProcessBalanceStockRepository _processBalanceStockRepository;
        private readonly IJWService _jwtService;
        public ProcessBalanceService(IProcessBalanceRepository repository,
                                     IProcessBalanceStockRepository processBalanceStockRepository,
                                     IProcessService processService,
                                     IJWService jwtService,
                                     IStockRoom_InitialBalanceRepository stockRoom_InitialBalanceRepository,
                                     IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._jwtService = jwtService;
            this._processService = processService;
            this._processBalanceStockRepository = processBalanceStockRepository;
            this._stockRoom_InitialBalanceRepository = stockRoom_InitialBalanceRepository;
        }

        public ProcessVM Active(long id)
        {
            throw new NotImplementedException();
        }

        public ProcessVM Edit(ProcessDto body)
        {
            var result = new ProcessVM();
            try
            {
                var processBalanceEntity = _repository.Get(body.ProcessBalanceID);
                if (processBalanceEntity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                var processEntity = _processService.GetByID(body.ID);
                if (processEntity.hasError == true)
                    throw new CustomErrorException(processEntity.ErrorMessage, processEntity.Code);

                bool hasError = false;
                var errorMessages = new List<String>();
                var userid = _jwtService.GetUserID();
                foreach (var item in body.processBalanceDtos)
                {
                    long totalPrice = 0;
                    foreach (var stockBalance in item.stockRoom_InitialBalanceDtos)
                    {

                        var processBalanceStock = processBalanceEntity.processBalanceStockEntities.Where(z => z.Id == stockBalance.ID).FirstOrDefault();
                        if (processBalanceStock == null)
                        {
                            hasError = true;
                            errorMessages.Add("مقداری یافت نشد.");
                            break;
                        }
                        var stockBalanceEntity = _stockRoom_InitialBalanceRepository.Get(processBalanceStock.StockRoomID);
                        if (stockBalanceEntity == null)
                        {
                            hasError = true;
                            errorMessages.Add(ConstantsValue.notFoundMsg);
                            break;
                        }
                        if (stockBalanceEntity.InitialBalanceEntitiesFK_ID != item.InitialBalanceID)
                        {
                            hasError = true;
                            errorMessages.Add("برای موجودی اولیه " + item.InitialBalanceID + " درون انبار با شناسه " + stockBalanceEntity.StockRoom_InitialBalanceFK_ID + " موجودی تعریف نگردیده است.");
                            break;
                        }

                        if (stockBalance.Count > (stockBalanceEntity.CurrentCount + processBalanceStock.Count))
                        {
                            hasError = true;
                            errorMessages.Add("تعداد انتخاب شده بیشتر از ظرفیت موجودی انبار می باشد.");
                            break;
                        }
                        else
                        {
                            stockBalanceEntity.ModifiedById = userid;
                            stockBalanceEntity.CurrentCount = (stockBalanceEntity.CurrentCount + processBalanceStock.Count) - stockBalance.Count;
                            processBalanceStock.Count = stockBalance.Count;
                            totalPrice += long.Parse(stockBalanceEntity.PricePerUnit) * stockBalance.Count;
                            processBalanceStock.TotalPrice = (long.Parse(stockBalanceEntity.PricePerUnit) * stockBalance.Count).ToString();
                            processBalanceStock.ModifiedById = userid;
                            _processBalanceStockRepository.Update(processBalanceStock);
                            _stockRoom_InitialBalanceRepository.Update(stockBalanceEntity);
                        }
                    }

                    processBalanceEntity.TotalPrice = totalPrice.ToString();
                    processBalanceEntity.Count = item.stockRoom_InitialBalanceDtos.Sum(z => z.Count);
                    if (hasError == true)
                        break;
                    _repository.Update(processBalanceEntity);
                }
                if (hasError == false)
                {
                    _processBalanceStockRepository.SaveChanges();
                    _stockRoom_InitialBalanceRepository.SaveChanges();
                    _repository.SaveChanges();
                }
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

        public ProcessVM GetAll()
        {
            throw new NotImplementedException();
        }

        public ProcessVM GetByDto(ProcessDto body)
        {
            throw new NotImplementedException();
        }

        public ProcessVM GetByID(long Id)
        {
            throw new NotImplementedException();
        }

        public ProcessVM Insert(ProcessDto body)
        {
            var result = new ProcessVM();
            try
            {
                var processEntity = _processService.GetByID(body.ID);
                if (processEntity.hasError == true)
                    throw new CustomErrorException(processEntity.ErrorMessage, processEntity.Code);

                bool hasError = false;
                var errorMessages = new List<String>();
                var userid = _jwtService.GetUserID();
                foreach (var item in body.processBalanceDtos)
                {
                    var processBalanceEntity = new ProcessBalanceEntity();
                    processBalanceEntity.InitialBalanceID = item.InitialBalanceID;
                    processBalanceEntity.CreatedById = userid;
                    processBalanceEntity.processEntityID = body.ID;
                    if (item.stockRoom_InitialBalanceDtos.GroupBy(z => z.StockRoom_InitialBalanceFK_ID).ToList().First().ToList().Count() > 1)
                    {
                        hasError = true;
                        errorMessages.Add(ConstantsValue.missingFormatMsg);
                        break;
                    }
                    long totalPrice = 0;
                    foreach (var stockBalance in item.stockRoom_InitialBalanceDtos)
                    {
                        var stockBalanceEntity = _stockRoom_InitialBalanceRepository.Get(stockBalance.StockRoom_InitialBalanceFK_ID);
                        if (stockBalanceEntity == null)
                        {
                            hasError = true;
                            errorMessages.Add(ConstantsValue.notFoundMsg);
                            break;
                        }
                        if (stockBalanceEntity.InitialBalanceEntitiesFK_ID != item.InitialBalanceID)
                        {
                            hasError = true;
                            errorMessages.Add("برای موجودی اولیه " + item.InitialBalanceID + " درون انبار با شناسه " + stockBalanceEntity.StockRoom_InitialBalanceFK_ID + " موجودی تعریف نگردیده است.");
                            break;
                        }
                        if (stockBalance.Count > stockBalanceEntity.CurrentCount)
                        {
                            hasError = true;
                            errorMessages.Add("تعداد انتخاب شده بیشتر از ظرفیت موجودی انبار می باشد.");
                            break;
                        }
                        else
                        {
                            totalPrice += long.Parse(stockBalanceEntity.PricePerUnit) * stockBalance.Count;

                            _processBalanceStockRepository.Insert(new ProcessBalanceStockEntity
                            {
                                CreatedById = userid,
                                processBalanceEntity = processBalanceEntity,
                                ProcessBalanceID = processBalanceEntity.Id,
                                StockRoomID = stockBalanceEntity.Id,
                                Count = stockBalance.Count,
                                TotalPrice = (long.Parse(stockBalanceEntity.PricePerUnit) * stockBalance.Count).ToString()

                            });
                            stockBalanceEntity.ModifiedById = userid;
                            stockBalanceEntity.CurrentCount = stockBalanceEntity.CurrentCount - stockBalance.Count;
                            _stockRoom_InitialBalanceRepository.Update(stockBalanceEntity);
                        }
                    }
                    if (hasError == true)
                        break;
                    processBalanceEntity.TotalPrice = totalPrice.ToString();
                    processBalanceEntity.Count = item.stockRoom_InitialBalanceDtos.Sum(z => z.Count);
                    _repository.Insert(processBalanceEntity);
                }
                if (hasError == false)
                    _repository.SaveChanges();
                else
                    throw new CustomErrorException(errorMessages[0], ConstantsValue.missingFormatCode, errorMessages);
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

        public ProcessVM Remove(long[] id)
        {
            throw new NotImplementedException();
        }

        public ProcessVM Remove(long id)
        {
            throw new NotImplementedException();
        }

        public ProcessVM Search(ProcessDto body)
        {
            throw new NotImplementedException();
        }
    }
}
