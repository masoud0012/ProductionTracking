using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.StockRoom;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Repo.Troual.StockRoomRepository;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.StockRoom;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.StockRoom
{
    public class StockRoom_BalanceService : IStockRoom_BalanceService
    {
        private readonly IMapper _mapper;
        private readonly IStockRoom_InitialBalanceRepository _repository;
        private readonly IStockRoomService _stockRoomService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IJWService _jwtService;
        public StockRoom_BalanceService(IStockRoom_InitialBalanceRepository repository,
                                        IStockRoomService stockRoomService,
                                        IJWService jwtService,
                                        IServiceProvider services,
                                        IMapper mapper)
        {
            this._stockRoomService = stockRoomService;
            this._repository = repository;
            this._mapper = mapper;
            this._serviceProvider = services;
            this._jwtService = jwtService;
        }

        public StockRoomVM GetAll()
        {
            return new StockRoomVM
            {
                stockRoomBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(_repository.GetALL())
            };
        }

        public StockRoomVM GetByID(long ID)
        {
            StockRoomVM result = new StockRoomVM();
            try
            {
                var entity = _repository.Get(ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                result.stockRoomBalanceDto = _mapper.Map<StockRoom_InitialBalanceEntity, StockRoom_InitialBalanceDto>(entity);
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

        private void CheckForInsertAndUpdate(StockRoomVM Stock, InitialBalanceVM balance, long Count)
        {
            if (Stock.stockRoomDto == null)
                throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
            if (balance.initialBalanceDto == null)
                throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
            //if (balance.initialBalanceDto.Count < Count)
            //    throw new CustomErrorException(ConstantsValue.assignBalanceCode, ConstantsValue.assignBalanceMsg);


        }
        public StockRoomVM Insert(StockRoom_InitialBalanceDto dto)
        {
            var result = new StockRoomVM();
            try
            {
                if (dto.Count < 0)
                    throw new CustomErrorException(ConstantsValue.ValueIsNotValidCode, ConstantsValue.ValueIsNotValidMsg);
                var _balanceService = _serviceProvider.GetRequiredService<IInitialBalanceService>();


                var Stock = _stockRoomService.GetByID(dto.StockRoom_InitialBalanceFK_ID);
                var balance = _balanceService.GetByID(dto.InitialBalanceEntitiesFK_ID);
                CheckForInsertAndUpdate(Stock, balance, dto.Count);
                if (_repository.ChecIsAssigned(Stock.stockRoomDto.ID, balance.initialBalanceDto.ID) == false)
                    throw new CustomErrorException(ConstantsValue.assignedBeforeBalanceCode, ConstantsValue.assignedBeforeBalanceMsg);

                var entity = new StockRoom_InitialBalanceEntity();
                entity.InitialBalanceEntitiesFK_ID = balance.initialBalanceDto.ID;
                entity.StockRoom_InitialBalanceFK_ID = Stock.stockRoomDto.ID;
                entity.CreatedById = _jwtService.GetUserID();
                entity.Count = dto.Count;
                entity.CurrentCount = dto.Count;
                entity.IsEnabled = true;
                entity.Title = dto.Title;
                _repository.Insert(entity);
                _repository.SaveChanges();
                result.stockRoomBalanceDto = _mapper.Map<StockRoom_InitialBalanceEntity,StockRoom_InitialBalanceDto >(entity);
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

        public StockRoomVM Remove(long ID)
        {
            var result = new StockRoomVM();
            try
            {
                var entity = _repository.Get(ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                _repository.Remove(entity);
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

        public StockRoomVM Updae(StockRoom_InitialBalanceDto body)
        {
            var result = new StockRoomVM();
            try
            {
                if (body.Count < 0)
                    throw new CustomErrorException(ConstantsValue.ValueIsNotValidCode, ConstantsValue.ValueIsNotValidMsg);
                var entity = _repository.FindAllByID(body.ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);

                var _balanceService = _serviceProvider.GetRequiredService<IInitialBalanceService>();
                var balance = _balanceService.GetByID(entity.InitialBalanceEntitiesFK_ID.Value);
                var Stock = _stockRoomService.GetByID(entity.StockRoom_InitialBalanceFK_ID.Value);
                entity.ModifiedById = _jwtService.GetUserID();
                entity.Count = body.Count;
                entity.CurrentCount = body.CurrentCount;
                entity.PricePerUnit = body.PricePerUnit;
                _repository.Update(entity);
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

        public StockRoomVM Active(long id)
        {

            var result = new StockRoomVM();
            try
            {
                var entity = _repository.GetForActive(id);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);

                _repository.Remove(entity);
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

        public StockRoomVM stockRoom_InitialBalanceEntitiesValidationForInsert(InitialBalancePoco body, long InitialBalanceID)
        {
            var result = new StockRoomVM();
            try
            {
                var stockRoomResult = new List<StockRoom_InitialBalanceEntity>();
                if (body.StockRoom_InitialBalanceDto != null)
                {
                    if (body.StockRoom_InitialBalanceDto.Count > 0)
                    {
                        var errors = new List<string>();
                        var userid = _jwtService.GetUserID();
                        bool hasError = false;
                        foreach (var item in body.StockRoom_InitialBalanceDto)
                        {

                            var stock = _stockRoomService.GetByID(item.StockRoom_InitialBalanceFK_ID);
                            if (stock.stockRoomDto == null)
                            {
                                hasError = true;
                                string errorMessage = "انبار با شناسه : " + item.StockRoom_InitialBalanceFK_ID + " اشتباه است.";
                                errors.Add(errorMessage);
                            }
                            if (hasError == false)
                            {
                                var entity = new StockRoom_InitialBalanceEntity();
                                entity.CreatedById = userid;
                                entity.StockRoom_InitialBalanceFK_ID = stock.stockRoomDto.ID;
                                entity.InitialBalanceEntitiesFK_ID = InitialBalanceID;
                                entity.CurrentCount = item.Count;
                                entity.Count = item.Count;
                                stockRoomResult.Add(entity);
                            }
                        }
                        if (hasError == true)
                            throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.missingFormatCode, errors);
                        else
                        {
                            _repository.Insert(stockRoomResult);
                            _repository.SaveChanges();
                        }
                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
                result.ErrorMessages = ex.errorMessages;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public StockRoomVM UpdateList(List<StockRoom_InitialBalanceDto> body)
        {
            var result = new StockRoomVM();
            try
            {
                foreach (var item in body)
                {
                    var entity = _repository.Get(item.ID);
                    if (entity == null)
                        throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);

                    var currentCount = 0;
                    //if (entity.Count > item.Count)
                    //{
                    //    entity.CurrentCount = entity.CurrentCount + (item.Count - entity.Count);
                    //}
                    //else if(entity.Count<item.Count)
                    //{
                    //    entity.CurrentCount = entity.CurrentCount + (item.Count - entity.Count);
                    //}
                    var userid = _jwtService.GetUserID();
                    if (item.CurrentCount > 0)
                    {
                        entity.ModifiedById = userid;
                        entity.CurrentCount =  item.CurrentCount;
                        entity.PricePerUnit = item.PricePerUnit;
                        _repository.Update(entity);
                    }

                }
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public StockRoomVM Increase(StockRoom_InitialBalanceDto body)
        {
            var result = new StockRoomVM();
            try
            {
                var entity = _repository.Get(body.ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.ModifiedById = _jwtService.GetUserID();
                entity.ModifiedDate = DateTime.Now;
                entity.CurrentCount = entity.CurrentCount + body.Count;
                _repository.Update(entity);
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
