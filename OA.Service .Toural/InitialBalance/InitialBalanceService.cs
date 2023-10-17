using AutoMapper;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.StockRoom;
using OA.Repo.Troual.Contracts.InitialBalance;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.Contracts.JobService;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.StockRoom;
using OA.Service_.Toural.ViewModels.Cost;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Service_.Toural.InitialBalance
{
    public class InitialBalanceService : IInitialBalanceService
    {
        private readonly IMapper _mapper;
        private readonly IInitialBalanceRepository _balanceRepository;
        private readonly IGeneralParameterService _generalParameterService;
        private readonly IStockRoomService _stockRoomService;
        private readonly IFileService _fileService;
        private readonly IJobServices _jobService;
        private readonly IJWService _jwtService;
        private readonly IStockRoom_InitialBalanceRepository _stockRoom_InitialBalanceRepository;
        private readonly IWastageRepository _wastageRepository;
        private readonly IStockRoom_BalanceService _stockRoom_BalanceService;
        private readonly IServiceProvider _provider;
        public InitialBalanceService(IInitialBalanceRepository balanceRepository,
                                     IGeneralParameterService generalParameterService,
                                     IStockRoom_BalanceService stockRoom_BalanceService,
                                     IWastageRepository wastageRepository,
                                     IJobServices jobService,
                                     IServiceProvider provider,
                                     IFileService fileService,
                                      IJWService jwtService,
                                     IStockRoomService stockRoomService,
                                     IStockRoom_InitialBalanceRepository stockRoom_InitialBalanceRepository,
                                     IMapper mapper)
        {
            this._fileService = fileService;
            this._balanceRepository = balanceRepository;
            this._stockRoom_BalanceService = stockRoom_BalanceService;
            this._mapper = mapper;
            _provider = provider;
            this._jwtService = jwtService;
            this._generalParameterService = generalParameterService;
            this._jobService = jobService;
            this._stockRoomService = stockRoomService;
            this._stockRoom_InitialBalanceRepository = stockRoom_InitialBalanceRepository;
            this._wastageRepository = wastageRepository;
        }

        private InitialBalanceEntity GetInitialBalanceEntity(long id)
        {
            var entity = _balanceRepository.Get(id);
            if (entity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;

        }
        public InitialBalanceVM Active(long id)
        {
            var result = new InitialBalanceVM();
            try
            {

                var entity = _balanceRepository.getForRemove(id);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.IsEnabled = true;
                _balanceRepository.Update(entity);
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

        public InitialBalanceVM GetAll()
        {
            var result = new InitialBalanceVM();
            result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(_balanceRepository.GetAll());
            return result;
        }

        public InitialBalanceVM GetByID(long ID)
        {
            var result = new InitialBalanceVM();
            try
            {
                var entity = _balanceRepository.Get(ID);
                result.initialBalanceDto = _mapper.Map<InitialBalanceEntity, InitialBalancePoco>(entity);
                result.StockRoom_InitialBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(entity.StockRoom_InitialBalanceEntity);
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


        private InitialBalanceEntity GetStockByID(long ID)
        {
            var entity = _balanceRepository.Get(ID);
            if (entity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;
        }

        public InitialBalanceVM Remove(long[] id)
        {
            var result = new InitialBalanceVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = GetStockByID(item);
                    entity.ModifiedById = _jwtService.GetUserID();
                    entity.IsEnabled = false;
                }
                _balanceRepository.SaveChanges();
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


        public InitialBalanceVM Insert(InitialBalancePoco Entity, IFormFile formFile, FlowProcessEntity flowProcessEntity)
        {
            var result = new InitialBalanceVM();
            try
            {
                if (string.IsNullOrEmpty(Entity.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (_balanceRepository.GetQuery(z => z.Title == Entity.Title) > 0)
                {
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                }


                Entity.ID = 0;
                if (Entity.UnitMeaurementFK_ID == 0)
                    Entity.UnitMeaurementFK_ID = 2;
                if (Entity.TypeMaterialFK_ID == 0)
                    Entity.TypeMaterialFK_ID = 6;
                var Unit = _generalParameterService.GetChildByID(Entity.UnitMeaurementFK_ID, Common.EnumValues.ParentEnum.UnitMeasurement);

                var categoryType = _generalParameterService.GetChildByID(Entity.CategoryTypeFK_ID, Common.EnumValues.ParentEnum.Category);
                if (Unit.generalParamterDto == null)
                    throw new CustomErrorException(ConstantsValue.notFoundUnitMsg, ConstantsValue.notFoundUnitCode);
                if (categoryType.generalParamterDto == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCategoryMsg, ConstantsValue.notFoundCategoryCode);

                if (string.IsNullOrEmpty(Entity.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var objEntity = _mapper.Map<InitialBalancePoco, InitialBalanceEntity>(Entity);
                if (Unit.generalParamterDto != null)
                    objEntity.UnitMeaurementFK_ID = Unit.generalParamterDto.ID;
                else
                    objEntity.UnitMeaurementFK_ID = null;
                if (categoryType.generalParamterDto != null)
                    objEntity.CategoryTypeFK_ID = categoryType.generalParamterDto.ID;
                else
                    objEntity.CategoryTypeFK_ID = null;
                objEntity.TypeMaterialFK_ID = 6;
                if (flowProcessEntity != null)
                {
                    if (flowProcessEntity.processEntity.IsFinalStep == true)
                    {
                        objEntity.TypeMaterialFK_ID = 7;
                    }
                    else
                    {
                        objEntity.TypeMaterialFK_ID = 6;
                    }
                    objEntity.flowProcessEntity = flowProcessEntity;
                    objEntity.ProposedPrice = Int64.Parse(flowProcessEntity.FinalCost);
                    //var pricePerUnit = Int64.Parse(Decimal.Parse(flowProcessEntity.FinalCost / Entity.StockRoom_InitialBalanceDto.Sum(z => z.Count)).ToString());
                }
                string uploadPath = string.Empty;
                if (formFile != null)
                {
                    if (formFile.Length >= 80000)
                        throw new CustomErrorException(ConstantsValue.imageSizeErrorMessage, ConstantsValue.imageSizeErrorCode);
                    if (!formFile.FileName.EndsWith("jpg") && !formFile.FileName.EndsWith("png") && !formFile.FileName.EndsWith("jpeg"))
                        throw new CustomErrorException(ConstantsValue.imageFormatErrorMessage, ConstantsValue.imageFormatErrorCode);
                    uploadPath = _fileService.Upload(formFile);
                }
                objEntity.CreatedById = _jwtService.GetUserID();
                if (flowProcessEntity == null)
                    objEntity.Price = Entity.Price;
                else
                    objEntity.Price = Entity.Price / Entity.StockRoom_InitialBalanceDto.Sum(z => z.Count);
                objEntity.ImageUri = uploadPath;
                objEntity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.Balance) + _balanceRepository.LastInsertedID();
                var balanceEntity = _balanceRepository.Insert(objEntity);
                _balanceRepository.SaveChanges();
                var resultStock = _stockRoom_BalanceService.stockRoom_InitialBalanceEntitiesValidationForInsert(Entity, balanceEntity.Id);
                if (resultStock.hasError)
                    throw new CustomErrorException(resultStock.ErrorMessage, resultStock.Code, resultStock.ErrorMessages);
                _balanceRepository.SaveChanges();

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
                result.ErrorMessages = ex.errorMessages;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        private List<StockRoom_InitialBalanceEntity> stockRoom_InitialBalanceEntitiesValidationForInsert(InitialBalancePoco body, long InitialBalanceID)
        {
            List<StockRoom_InitialBalanceEntity> result = new List<StockRoom_InitialBalanceEntity>();
            if (body.StockRoom_InitialBalanceDto != null)
            {
                if (body.StockRoom_InitialBalanceDto.Count > 0)
                {
                    var errors = new List<string>();
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
                        if (item.Count <= 0)
                        {
                            string errorMessage = "مقدار موجودی برای انبار با شناسه " + item.StockRoom_InitialBalanceFK_ID + " نمی تواند کمتر از 1 باشد.";
                            errors.Add(errorMessage);
                        }
                        if (hasError == false)
                        {
                            var entity = _mapper.Map<StockRoom_InitialBalanceDto, StockRoom_InitialBalanceEntity>(item);
                            entity.StockRoom_InitialBalanceFK_ID = stock.stockRoomDto.ID;
                            entity.InitialBalanceEntitiesFK_ID = InitialBalanceID;
                            result.Add(entity);
                        }
                    }
                    if (hasError == true)
                        throw new CustomErrorException("", ConstantsValue.missingFormatCode, errors);
                    else
                    {
                        _stockRoom_InitialBalanceRepository.Insert(result);
                        _stockRoom_InitialBalanceRepository.SaveChanges();
                    }
                }
            }
            return result;
        }

        public InitialBalanceVM Update(InitialBalancePoco body, IFormFile formFile)
        {
            var result = new InitialBalanceVM();
            try
            {
                var Unit = _generalParameterService.GetChildByID(body.UnitMeaurementFK_ID, Common.EnumValues.ParentEnum.UnitMeasurement);
                var TypeMaterial = _generalParameterService.GetChildByID(body.TypeMaterialFK_ID, Common.EnumValues.ParentEnum.TypeMaterial);
                var CategoryType = _generalParameterService.GetChildByID(body.CategoryTypeFK_ID, Common.EnumValues.ParentEnum.Category);
                if (body.UnitMeaurementFK_ID != 0)
                {
                    if (Unit.generalParamterDto == null)
                        throw new CustomErrorException(ConstantsValue.notFoundUnitMsg, ConstantsValue.notFoundUnitCode);
                }
                if (body.TypeMaterialFK_ID != 0)
                {
                    if (TypeMaterial.generalParamterDto == null)
                        throw new CustomErrorException(ConstantsValue.notFoundTypeMaterialMsg, ConstantsValue.notFoundTypeMaterialCode);
                }
                if (body.CategoryTypeFK_ID != 0)
                {
                    if (CategoryType.generalParamterDto == null)
                        throw new CustomErrorException(ConstantsValue.notFoundTypeMaterialMsg, ConstantsValue.notFoundTypeMaterialCode);
                }

                var entity = GetInitialBalanceEntity(body.ID);
                entity.ModifiedDate = DateTime.Now;
                entity.Title = body.Title;
                entity.Price = body.Price;
                entity.ModifiedById = _jwtService.GetUserID();
                entity.Description = body.Description;
                if (formFile != null)
                {
                    string uploadPath = _fileService.Upload(formFile);
                    entity.ImageUri = uploadPath;
                }
                if (Unit.generalParamterDto != null)
                    entity.UnitMeaurementFK_ID = Unit.generalParamterDto.ID;
                else
                    entity.UnitMeaurementFK_ID = null;
                if (TypeMaterial.generalParamterDto != null)
                    entity.TypeMaterialFK_ID = TypeMaterial.generalParamterDto.ID;
                else
                    entity.TypeMaterialFK_ID = null;
                if (CategoryType.generalParamterDto != null)
                    entity.CategoryTypeFK_ID = CategoryType.generalParamterDto.ID;
                else
                    entity.CategoryTypeFK_ID = null;
                _balanceRepository.Update(entity);
                _stockRoom_BalanceService.UpdateList(body.StockRoom_InitialBalanceDto);
                _stockRoom_InitialBalanceRepository.SaveChanges();

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
                result.ErrorMessages = ex.errorMessages;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public InitialBalanceVM Remove(long id)
        {
            var result = new InitialBalanceVM();
            try
            {
                var entity = GetInitialBalanceEntity(id);
                entity.IsEnabled = false;
                entity.ModifiedById = _jwtService.GetUserID();
                _balanceRepository.Update(entity);
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

        private Expression<Func<InitialBalanceEntity, bool>> query(Expression<Func<InitialBalanceEntity, bool>> expression)
        {
            return expression;
        }

        public InitialBalanceVM SearchBy(InitialBalancePoco body)
        {
            var result = new InitialBalanceVM();
            try
            {
                var expression = query(z => ((string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                    string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) && z.IsEnabled == true);

                var queryResult = _balanceRepository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _balanceRepository.GetQuery(expression);


                result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(queryResult);
                result.initialBalanceGroupsDtos = new List<InitialBalanceGroupsDto>();
                var dtos = queryResult.GroupBy(z => z.CategoryTypeFK_ID).ToList();

                foreach (var item in result.initialBalanceDtos)
                {
                    item.CategoryName = queryResult.Where(z => z.CategoryType.Id == item.CategoryTypeFK_ID).FirstOrDefault().CategoryType.Title;
                    item.UnitName = queryResult.Where(z => z.UnitMeasurement.Id == item.UnitMeaurementFK_ID).FirstOrDefault().UnitMeasurement.Title;
                    item.MaterialName = queryResult.Where(z => z.TypeMaterial.Id == item.TypeMaterialFK_ID).FirstOrDefault().TypeMaterial.Title;
                    item.CategoryTypeFK_ID = queryResult.Where(z => z.CategoryType.Id == item.CategoryTypeFK_ID).FirstOrDefault().CategoryType.Id;
                    item.UnitMeaurementFK_ID = queryResult.Where(z => z.UnitMeasurement.Id == item.UnitMeaurementFK_ID).FirstOrDefault().UnitMeasurement.Id;
                    item.TypeMaterialFK_ID = queryResult.Where(z => z.TypeMaterial.Id == item.TypeMaterialFK_ID).FirstOrDefault().TypeMaterial.Id;
                }
                foreach (var item in dtos)
                {
                    var itemGroup = new InitialBalanceGroupsDto();
                    itemGroup.CategoryTypeFK_ID = item.Key.Value;
                    itemGroup.CategoryName = queryResult.Where(z => z.CategoryType.Id == item.Key.Value).FirstOrDefault().CategoryType.Title;
                    itemGroup.CategoryCode = queryResult.Where(z => z.CategoryType.Id == item.Key.Value).FirstOrDefault().CategoryType.Code;
                    itemGroup.initialBalanceDtos = new List<InitialBalancePoco>();
                    var initialBalance = new List<InitialBalancePoco>();
                    foreach (var itemInitial in item.ToList())
                    {
                        initialBalance.Add(new InitialBalancePoco
                        {
                            Address = itemInitial.Address,
                            CategoryName = itemGroup.CategoryName,
                            CategoryTypeFK_ID = itemGroup.CategoryTypeFK_ID,
                            //createdDate= itemInitial.AddedDate!=null?itemInitial.AddedDate.ToString():"",
                            Description = itemInitial.Description,
                            Price = itemInitial.Price,
                            Title = itemInitial.Title,
                            Code = itemInitial.Code
                        });
                    }

                    itemGroup.initialBalanceDtos.AddRange(initialBalance);
                    result.initialBalanceGroupsDtos.Add(itemGroup);
                }

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


        public InitialBalanceVM SearchAutoComplete(InitialBalancePoco body)
        {
            var result = new InitialBalanceVM();
            try
            {
                var expression = query(z => ((string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                    string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.CategoryType.Id.ToString().Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &&
                    z.TypeMaterial.Code == "00020001" &&
                    z.IsEnabled == true);

                var queryResult = _balanceRepository.GetQueryGroupBy(expression, body.Page, body.Row, body.Sort);
                var countTable = _balanceRepository.GetQuery(expression);

                result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(queryResult);
                foreach (var item in queryResult)
                {
                    if (item.StockRoom_InitialBalanceEntity != null)
                        result.StockRoom_InitialBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(item.StockRoom_InitialBalanceEntity);
                    foreach (var itemDto in result.initialBalanceDtos)
                    {
                        if (itemDto.ID == item.Id)
                        {
                            itemDto.MaterialName = item.TypeMaterial != null ? item.TypeMaterial.Title : string.Empty;
                            itemDto.UnitName = item.UnitMeasurement != null ? item.UnitMeasurement.Title : string.Empty;
                            itemDto.CategoryName = item.CategoryType != null ? item.CategoryType.Title : string.Empty;
                        }
                    }
                }
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

        public InitialBalanceVM EditBalanceStock(InitialBalancePoco body)
        {
            var result = new InitialBalanceVM();
            try
            {
                var errors = new List<string>();
                bool hasError = false;
                if (body.StockRoom_InitialBalanceDto != null)
                {
                    if (body.StockRoom_InitialBalanceDto.Count >= 0)
                    {

                        foreach (var item in body.StockRoom_InitialBalanceDto)
                        {
                            var stockBalanceEntity = _stockRoom_InitialBalanceRepository.Get(item.ID);
                            if (stockBalanceEntity == null)
                            {
                                hasError = true;
                                string errorMessage = "شماره شناسه " + item.ID + "صحیح نمی باشد.";
                                errors.Add(errorMessage);
                            }
                            if (item.Count <= 0)
                            {
                                hasError = true;
                                string errorMessage = "مقدار موجودی برای شناسه " + item.ID + " نمی تواند از 1 کمتر باشد.";
                                errors.Add(errorMessage);
                            }
                            //if (item.CurrentCount <= 0)
                            //{
                            //    hasError = true;
                            //    string errorMessage = "مقدار موجودی برای شناسه " + item.ID + " نمی تواند از 1 کمتر باشد.";
                            //    errors.Add(errorMessage);
                            //}
                            if (hasError == false)
                            {
                                //stockBalanceEntity.IsEnabled = item.IsEnabled;
                                stockBalanceEntity.Count = item.Count;
                                stockBalanceEntity.ModifiedById = _jwtService.GetUserID();
                                stockBalanceEntity.CurrentCount = item.CurrentCount;
                            }

                        }
                        if (hasError == true)
                            throw new CustomErrorException(ConstantsValue.missingStockCountCode, string.Empty, errors);
                    }
                }

                if (hasError == false)
                    _stockRoom_InitialBalanceRepository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
                result.ErrorMessages = ex.errorMessages;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public InitialBalanceVM GetBalanceStockByID(long id)
        {
            var result = new InitialBalanceVM();
            try
            {
                var queryResult = _balanceRepository.Get(id);
                if (queryResult == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                var data = queryResult.StockRoom_InitialBalanceEntity.ToList();
                var stocksData = _stockRoomService.GetAll();

                var tmp = new List<StockRoom_InitialBalanceEntity>();
                if (data.Count != stocksData.stockRoomDtos.Count())
                {
                    foreach (var item in stocksData.stockRoomDtos)
                    {
                        if (!data.Any(z => z.StockRoom_InitialBalanceFK_ID == item.ID))
                        {
                            var resultStock = _stockRoom_BalanceService.Insert(new StockRoom_InitialBalanceDto
                            {
                                Count = 0,
                                CurrentCount = 0,
                                InitialBalanceEntitiesFK_ID = id,
                                StockRoom_InitialBalanceFK_ID = item.ID,
                                Title = item.Title
                            });
                            var entity = _mapper.Map<StockRoom_InitialBalanceDto, StockRoom_InitialBalanceEntity>(resultStock.stockRoomBalanceDto);
                            tmp.Add(entity);
                        }
                    }
                    data.AddRange(tmp);
                }
                result.StockRoom_InitialBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(data);
                foreach (var item in result.StockRoom_InitialBalanceDtos)
                {
                    item.Title = stocksData.stockRoomDtos.Where(z => z.ID == item.StockRoom_InitialBalanceFK_ID).FirstOrDefault().Title;
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

        public InitialBalanceVM SearchAutoCompleteByID(Int64 ID)
        {
            var result = new InitialBalanceVM();
            try
            {
                var queryResult = _balanceRepository.Get(ID);
                result.initialBalanceDto = _mapper.Map<InitialBalanceEntity, InitialBalancePoco>(queryResult);

                if (queryResult.StockRoom_InitialBalanceEntity != null)
                    result.StockRoom_InitialBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(queryResult.StockRoom_InitialBalanceEntity);
                if (result.initialBalanceDto.ID == queryResult.Id)
                {
                    result.initialBalanceDto.MaterialName = queryResult.TypeMaterial != null ? queryResult.TypeMaterial.Title : string.Empty;
                    result.initialBalanceDto.UnitName = queryResult.UnitMeasurement != null ? queryResult.UnitMeasurement.Title : string.Empty;
                    result.initialBalanceDto.CategoryName = queryResult.CategoryType != null ? queryResult.CategoryType.Title : string.Empty;
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

        public InitialBalanceVM SearchAutoCompleteExcept(InitialBalancePoco body)
        {
            var result = new InitialBalanceVM();
            try
            {
                var expression = query(z => ((string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                    string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.CategoryType.Id.ToString().Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title))
                    && body.ids.Count() > 0 ? !body.ids.Contains(z.Id) : true
                    && z.TypeMaterialFK_ID == 6
                    && z.IsEnabled == true);

                var queryResult = _balanceRepository.GetQueryGroupBy(expression, body.Page, body.Row, body.Sort).Where(z => z.TypeMaterialFK_ID == 6).ToList();
                if (body.ids != null)
                    foreach (var item in body.ids)
                    {
                        queryResult.RemoveAll(z => z.Id == item);
                    }
                var countTable = _balanceRepository.GetQuery(expression);

                result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(queryResult);
                foreach (var item in queryResult)
                {
                    if (item.StockRoom_InitialBalanceEntity != null)
                        result.StockRoom_InitialBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(item.StockRoom_InitialBalanceEntity);
                    foreach (var itemDto in result.initialBalanceDtos)
                    {
                        if (itemDto.ID == item.Id)
                        {
                            itemDto.MaterialName = item.TypeMaterial != null ? item.TypeMaterial.Title : string.Empty;
                            itemDto.UnitName = item.UnitMeasurement != null ? item.UnitMeasurement.Title : string.Empty;
                            itemDto.CategoryName = item.CategoryType != null ? item.CategoryType.Title : string.Empty;
                        }
                    }
                }
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

        private InitialBalanceVM GetInitialBalanceForCost(DateTime startDateTime, DateTime EndDateTime)
        {
            var result = new InitialBalanceVM();
            var queryResult = _balanceRepository.GetQueryData(z => z.AddedDate >= startDateTime && z.AddedDate <= EndDateTime && z.IsEnabled == true && z.TypeMaterial.Code == "00020002").ToList();
            result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(queryResult);
            return result;
        }
        private decimal calculateSalaryUsers(List<FlowProcessEntity> flowProcessEntities)//محاسبه هزینه اتلاف شده کارگر
        {
            decimal sumSalary = 0;
            foreach (var entity in flowProcessEntities)
            {
                if (entity.IsForeignWorker == 15)//چک میشود که خروجی نهایی به صورت داخلی بوده است یا خیر.
                {
                    foreach (var userSalaryEntity in entity.flowProcessUserSalaryEntities)
                    {
                        if (userSalaryEntity.User.SalaryTypeFK_ID == 14)//ساعتی
                        {
                            var diffHours = userSalaryEntity.User.MaxWorkPerHour - userSalaryEntity.SumHours;
                            sumSalary = sumSalary + diffHours * (userSalaryEntity.User.SalaryPerHour);
                        }
                        else//ماهیانه
                        {
                            var diffDay = userSalaryEntity.User.MaxWorkPerDay - userSalaryEntity.SumDays;
                            sumSalary = sumSalary + diffDay * (userSalaryEntity.User.SalaryPerMonth / userSalaryEntity.User.MaxWorkPerDay);
                        }
                    }
                }

            }
            return sumSalary;
        }

        public InitialBalanceVM CalculateProducts(DateTime startMiladiDate, DateTime endMiladiDate, Decimal totalCostPrice)
        {
            var result = new InitialBalanceVM();
            result.initialBalanceDtos = new List<InitialBalancePoco>();
            try
            {
                var totalCostPriceLog = totalCostPrice;
                var initialBalanceData = GetInitialBalanceForCost(startMiladiDate, endMiladiDate);//بارگزاری تمام مواد اولیه ماه قبل
                var entities = _balanceRepository.Get(initialBalanceData.initialBalanceDtos.Select(z => z.ID).ToArray()).ToList();
                var totalPriceBalanceLastMonth = initialBalanceData.initialBalanceDtos.Sum(z => z.Price);
                var usersCost = calculateSalaryUsers(entities.Select(z => z.flowProcessEntity).ToList());
                totalCostPrice = totalCostPrice + usersCost;
                var weightProduct = Decimal.Round(totalCostPrice / totalPriceBalanceLastMonth, 5, MidpointRounding.AwayFromZero);//بدست آوردن ارزش هزینه
                foreach (var item in entities)
                {
                    item.ProposedPrice = Int64.Parse(Decimal.Round((weightProduct * item.Price) + item.Price, 0, MidpointRounding.AwayFromZero).ToString());
                    item.PriceBeforeCalculation = item.Price;
                    item.Price = Decimal.Round((weightProduct * item.Price) + item.Price, 0, MidpointRounding.AwayFromZero);
                    item.TotalCostPrice = totalCostPrice;//هزینه با هزینه کارگر
                    item.WeighProductInCalculation = weightProduct;
                    item.TotalCostPriceLog = totalCostPriceLog;//هزینه خالص
                    item.TotalUserCost = usersCost;
                    var balanceDto = _mapper.Map<InitialBalanceEntity, InitialBalancePoco>(item);
                    result.initialBalanceDtos.Add(balanceDto);
                }
                result.initialBalanceDto = new InitialBalancePoco();
                result.initialBalanceDto.WeightInCalculation = weightProduct;
                _balanceRepository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public InitialBalanceVM GetByFlowID(long ID)
        {
            var result = new InitialBalanceVM();
            try
            {
                var entity = _balanceRepository.GetQueryData(z => z.flowProcessEntityID == ID && z.IsEnabled == true).FirstOrDefault();
                result.initialBalanceDto = _mapper.Map<InitialBalanceEntity, InitialBalancePoco>(entity);
                result.StockRoom_InitialBalanceDtos = _mapper.Map<List<StockRoom_InitialBalanceEntity>, List<StockRoom_InitialBalanceDto>>(entity.StockRoom_InitialBalanceEntity);
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

        public InitialBalanceVM CalculateByJob()
        {
            var result = new InitialBalanceVM();
            try
            {
                var prevShamsiMonth = PersianDateTime.Now.Month - 1;
                var currentShamsiMonth = PersianDateTime.Now.Month;
                if (PersianDateTime.Now.Month == 1)
                    prevShamsiMonth = 12;


                var currentDaysOfMonth = PersianDateTime.GetDaysInMonth(PersianDateTime.Now.Year, prevShamsiMonth);
                var prevStartMiladiDate = CommonUtility.ConvertPersianDateToGregorianDate(PersianDateTime.Now.Year, PersianDateTime.Now.Month, 1).AddMonths(-1);
                var prevEndMiladiDate = CommonUtility.ConvertPersianDateToGregorianDate(PersianDateTime.Now.Year, PersianDateTime.Now.Month, currentDaysOfMonth).AddMonths(-1);
                //در اینجا روز اول ماه قبل با روز آخر ماه قبل به دست می آید.

                var currentStartMiladiDate = CommonUtility.ConvertPersianDateToGregorianDate(PersianDateTime.Now.Year, PersianDateTime.Now.Month, 1);
                var currentEndMiladiDate = CommonUtility.ConvertPersianDateToGregorianDate(PersianDateTime.Now.Year, PersianDateTime.Now.Month, PersianDateTime.GetDaysInMonth(PersianDateTime.Now.Year, currentShamsiMonth));
                //در اینجا روز اول ماه جاری با روز آخر ماه حاری به دست می آید.

                var initialBalanceData = GetInitialBalanceForCost(currentStartMiladiDate, currentEndMiladiDate);//بارگزاری تمام مواد اولیه ماه جاری
                var totalPriceBalanceCurrentMonth = initialBalanceData.initialBalanceDtos.Sum(z => z.Price);
                var entities = _balanceRepository.Get(initialBalanceData.initialBalanceDtos.Select(z => z.ID).ToArray()).ToList();
                var usersCost =long.Parse(calculateSalaryUsers(entities.Select(z => z.flowProcessEntity).ToList()).ToString());
                //لیست تمام دستمزدهای داده شده ماه جاری با محصولات تولیدی ماه جاری

                var expression = query(z => z.TypeMaterialFK_ID == 7);

                var queryResult = _balanceRepository.GetQueryData(expression);
                var countTable = _balanceRepository.GetQuery(expression);

                var costService = _provider.GetRequiredService<ICostService>();
                var costPrice = costService.GetAllCosts(currentStartMiladiDate, currentEndMiladiDate);
                var totalCostOfCurrentMonth = costPrice.costDtos.Sum(z => z.CostAmount / z.Month)+usersCost;//مجموع هزینه های ماه جاری
                //var prevMonthJob = _jobService.GetPrevMonthJob(prevStartMiladiDate, prevEndMiladiDate,totalCostOfCurrentMonth,0);//محاصبه ضریب سرشکن ماه جاری بر اساس هزینه و دستمزد امروز
                var prevMonthJob = _jobService.GetPrevMonthJob(prevStartMiladiDate,prevEndMiladiDate);//محاصبه ضریب سرشکن ماه جاری بر اساس هزینه و دستمزد امروز
                result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(queryResult);


                foreach (var item in result.initialBalanceDtos)
                {
                    item.Count = queryResult.Where(z => z.Id == item.ID).FirstOrDefault().StockRoom_InitialBalanceEntity.Sum(z=>z.CurrentCount);
                    item.PriceBeforeCalculation = Decimal.Round(item.Price, 0);//قیمت تمام شده محصول
                    if (prevMonthJob != null)
                        item.ProposedPrice = Int64.Parse((Decimal.Round((item.Price * prevMonthJob.jobDto.WeightInCalculation) + item.Price, 0)).ToString());//قیمت پیشنهادی بر اساس هزینه سرشکن ماه پیش
                    else
                        item.ProposedPrice = Int64.Parse(Decimal.Round(item.Price, 0).ToString());
                    item.WeightInCalculation = prevMonthJob != null ? prevMonthJob.jobDto.WeightInCalculation : 0;
                    item.CategoryName = queryResult.FirstOrDefault(z => z.Id == item.ID).CategoryType.Title;
                }
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

        public ExcelDto PrintExcel()
        {
            var result = new ExcelDto();
            try
            {
                var products = CalculateByJob();
                if (products.hasError == true)
                    throw new CustomErrorException(products.ErrorMessage, products.Code);
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string fileName = "Cost.xlsx";
                using (var workbook = new XLWorkbook())
                {
                    workbook.RightToLeft = true;
                    IXLWorksheet worksheet = workbook.Worksheets.Add(" محصولات نهایی");
                    worksheet.Cell(1, 1).Value = "شناسه";
                    worksheet.Cell(1, 2).Value = "عنوان";
                    worksheet.Cell(1, 3).Value = "دسته بندی";
                    worksheet.Cell(1, 4).Value = "قیمت تمام شده";
                    worksheet.Cell(1, 5).Value = "قیمت پیشنهادی";
                    worksheet.Cell(1, 6).Value = "درصد سرشکن";

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

                    for (int index = 1; index <= products.initialBalanceDtos.Count; index++)
                    {
                        worksheet.Cell(index + 1, 1).Value = products.initialBalanceDtos[index - 1].ID;
                        worksheet.Cell(index + 1, 2).Value = products.initialBalanceDtos[index - 1].Title;
                        worksheet.Cell(index + 1, 3).Value = products.initialBalanceDtos[index - 1].CategoryName;
                        worksheet.Cell(index + 1, 4).Value = products.initialBalanceDtos[index - 1].PriceBeforeCalculation;
                        worksheet.Cell(index + 1, 5).Value = products.initialBalanceDtos[index - 1].ProposedPrice;
                        worksheet.Cell(index + 1, 6).Value = products.initialBalanceDtos[index - 1].WeightInCalculation;
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
            catch (CustomErrorException ex)
            {
                return new ExcelDto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }



        public InitialBalanceVM SearchFinalProduct(InitialBalancePoco body)
        {
            return CalculateByJob();
        }

        public InitialBalanceVM GetWestage(InitialBalancePoco body)
        {
            InitialBalanceVM result = new InitialBalanceVM();
            try
            {
                var wasteges = _balanceRepository.GetWastage(body.ID);
                if (wasteges == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                result.initialBalanceDtos = new List<InitialBalancePoco>();
                foreach (var item in wasteges.wastageEntities)
                {
                    result.initialBalanceDtos.Add(new InitialBalancePoco
                    {
                        ID = item.Id,
                        InitialBalanceID = wasteges.Id,
                        Count = item.Count,
                        FlowTitle = item.FlowProcessEntity.Title,
                        Title = wasteges.Title,
                        CategoryName = wasteges.CategoryType.Title,
                        UnitName = wasteges.UnitMeasurement.Title
                    });
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public ExcelDto PrintWastage(InitialBalancePoco body)
        {
            var result = new ExcelDto();
            try
            {
                var products = GetWestage(body);
                if (products.hasError == true)
                    throw new CustomErrorException(products.ErrorMessage, products.Code);
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string fileName = "Cost.xlsx";
                using (var workbook = new XLWorkbook())
                {
                    workbook.RightToLeft = true;
                    IXLWorksheet worksheet = workbook.Worksheets.Add(" محصولات نهایی");
                    worksheet.Cell(1, 1).Value = "شناسه ";
                    worksheet.Cell(1, 2).Value = "عنوان خروجی فرایند";
                    worksheet.Cell(1, 3).Value = "عنوان ماده اولیه";
                    worksheet.Cell(1, 4).Value = "تعداد ضایعات";
                    worksheet.Cell(1, 5).Value = "دسته بندی";
                    worksheet.Cell(1, 6).Value = "واحد اندازه گیری";

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

                    for (int index = 1; index <= products.initialBalanceDtos.Count; index++)
                    {
                        worksheet.Cell(index + 1, 1).Value = products.initialBalanceDtos[index - 1].ID;
                        worksheet.Cell(index + 1, 2).Value = products.initialBalanceDtos[index - 1].FlowTitle;
                        worksheet.Cell(index + 1, 3).Value = products.initialBalanceDtos[index - 1].Title;
                        worksheet.Cell(index + 1, 4).Value = products.initialBalanceDtos[index - 1].Count;
                        worksheet.Cell(index + 1, 5).Value = products.initialBalanceDtos[index - 1].CategoryName;
                        worksheet.Cell(index + 1, 6).Value = products.initialBalanceDtos[index - 1].UnitName;
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
            catch (CustomErrorException ex)
            {
                return new ExcelDto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public InitialBalanceVM SearchWastage(InitialBalancePoco body)
        {
            var result = new InitialBalanceVM();
            try
            {
                var expression = queryWastage(z => ((string.IsNullOrEmpty(body.Title) || z.InitialBalanceEntity.Title.Contains(body.Title)) ||
                    string.IsNullOrEmpty(body.Title) || z.InitialBalanceEntity.Code.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.InitialBalanceEntity.Description.Contains(body.Title) ||
                    string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) && z.IsEnabled == true && z.Count > 0);

                var queryResult = _wastageRepository.GetQuery(expression, body.Page, body.Row, body.Sort).GroupBy(z => z.InitialBalanceEntityID).ToList();
                var countTable = _wastageRepository.GetQuery(expression);
                result.numberRows = queryResult.Count();
                result.WastageDtos = new List<WastageDto>();
                foreach (var item in queryResult)
                {
                    result.WastageDtos.Add(new WastageDto
                    {
                        ID = item.FirstOrDefault().Id,
                        UnitName = item.FirstOrDefault().InitialBalanceEntity.UnitMeasurement.Title,
                        WastageCount = item.Sum(z => z.Count),
                        Title = item.FirstOrDefault().InitialBalanceEntity.Title,
                        PricePerUnit = Int32.Parse(Decimal.Round(item.FirstOrDefault().InitialBalanceEntity.Price, 0).ToString())
                    });

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

        private Expression<Func<WastageEntity, bool>> queryWastage(Expression<Func<WastageEntity, bool>> expression)
        {
            return expression;
        }

        public ExcelDto PrintWastage()
        {
            var result = new ExcelDto();
            try
            {
                var products = _wastageRepository.GetAllValue().GroupBy(z => z.InitialBalanceEntityID).ToList();
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string fileName = "Cost.xlsx";
                using (var workbook = new XLWorkbook())
                {
                    workbook.RightToLeft = true;
                    IXLWorksheet worksheet = workbook.Worksheets.Add(" محصولات نهایی");
                    worksheet.Cell(1, 1).Value = "شناسه ";
                    worksheet.Cell(1, 2).Value = "عنوان ";
                    worksheet.Cell(1, 3).Value = "تعداد ضایعات";
                    worksheet.Cell(1, 4).Value = "واحد اندازه گیری";
                    worksheet.Cell(1, 5).Value = "قیمت هر واحد";
                    worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 2).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 3).Style.Fill.SetBackgroundColor(XLColor.Cyan);
                    worksheet.Cell(1, 4).Style.Fill.SetBackgroundColor(XLColor.Cyan);

                    IXLRange range = worksheet.Range(worksheet.Cell(1, 1).Address, worksheet.Cell(1, 8).Address);
                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;

                    for (int index = 1; index <= products.Count; index++)
                    {
                        worksheet.Cell(index + 1, 1).Value = products[index - 1].FirstOrDefault().Id;
                        worksheet.Cell(index + 1, 2).Value = products[index - 1].FirstOrDefault().InitialBalanceEntity.Title;
                        worksheet.Cell(index + 1, 3).Value = products[index - 1].Sum(z => z.Count);
                        worksheet.Cell(index + 1, 4).Value = products[index - 1].FirstOrDefault().InitialBalanceEntity.UnitMeasurement.Title;
                        worksheet.Cell(index + 1, 5).Value = products[index - 1].FirstOrDefault().InitialBalanceEntity.Price;
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
            catch (CustomErrorException ex)
            {
                return new ExcelDto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public InitialBalanceVM CalculateBalanceNewPrice(long ID, FlowProcessEntity flowProcessEntity, long Count)
        {
            InitialBalanceVM result = new InitialBalanceVM();
            try
            {
                var InitialBalance = _balanceRepository.Get(ID);
                var InitialBalanceInStockCounts = InitialBalance.StockRoom_InitialBalanceEntity.Sum(z => z.CurrentCount);
                var avgNewPrice = Decimal.Round(long.Parse(flowProcessEntity.FinalCost) / Count+InitialBalanceInStockCounts, 0, MidpointRounding.AwayFromZero);
                InitialBalance.PrevFlowPrice = InitialBalance.Price;
                InitialBalance.Price = InitialBalance.Price + avgNewPrice;
                _balanceRepository.Update(InitialBalance);
                _balanceRepository.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
    }
}
