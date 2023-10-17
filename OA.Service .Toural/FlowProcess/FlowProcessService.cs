using AutoMapper;
using Microsoft.AspNetCore.Http;
using OA.Common.Constants;
using OA.Common.EnumValues;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IFlowProcess;
using OA.Repo.Troual.Contracts.InitialBalance;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.FlowProcess;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.Contracts.StockRoom;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ViewModels.FlowProcess;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.Process;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.FlowProcess
{
    public class FlowProcessService : IFlowProcessService
    {
        private readonly IMapper _mapper;
        private readonly IFlowProcessRepository _repository;
        private readonly IInitialBalanceService _initialBalanceService;
        private readonly IStockRoom_BalanceService _stockRoom_BalanceService;
        private readonly IFlowUsersSalaryService _flowUsersSalaryService;
        private readonly IWastageRepository _wastageRepository;
        private readonly IFlowProcessStockInitialRepository _flowProcessStockInitialRepository;
        private readonly IJWService _jwtService;

        private readonly IGeneralParameterService _generalParameterService;
        private readonly IProcessService _processService;
        public FlowProcessService(IFlowProcessRepository repository,
                                 IFlowProcessStockInitialRepository flowProcessStockInitialRepository,
                                 IInitialBalanceService initialBalanceService,
                                 IJWService jwtService,
                                 IGeneralParameterService generalParameterService,
                                 IStockRoom_BalanceService stockRoom_BalanceService,
                                 IWastageRepository wastageRepository,
                                 IFlowUsersSalaryService flowUsersSalaryService,
                                 IProcessService processService,
                                IMapper mapper)
        {
            this._generalParameterService = generalParameterService;
            this._stockRoom_BalanceService = stockRoom_BalanceService;
            this._flowUsersSalaryService = flowUsersSalaryService;
            this._flowProcessStockInitialRepository = flowProcessStockInitialRepository;
            this._wastageRepository = wastageRepository;
            this._jwtService = jwtService;
            this._repository = repository;
            this._mapper = mapper;
            this._initialBalanceService = initialBalanceService;
            this._processService = processService;
        }
        public FlowProcessVM Edit(FlowProcessDto generalParamterPoco)
        {

            var result = new FlowProcessVM();
            try
            {

                var entity = _repository.Get(generalParamterPoco.ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                entity.ModifiedById = this._jwtService.GetUserID();
                entity.Title = generalParamterPoco.Title;
                entity.Description = generalParamterPoco.Description;
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

        public FlowProcessVM GetByID(long ID)
        {
            var result = new FlowProcessVM();
            try
            {
                var flowEntity = _repository.Get(ID);
                if (flowEntity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                result.flowProcessDto = _mapper.Map<FlowProcessEntity, FlowProcessDto>(flowEntity);
                if (result.flowProcessDto.TotalPrice != null)
                    if (result.flowProcessDto.TotalPrice.Contains('.'))
                        result.flowProcessDto.TotalPrice = result.flowProcessDto.TotalPrice.Split('.')[0];
                result.flowProcessDto.FinalCost = result.flowProcessDto.FinalCost.Split('.')[0];
                result.flowProcessDto.processID = flowEntity.processEntityID != null ? flowEntity.processEntityID.Value : 0;
                if (flowEntity.processEntity != null)
                {
                    result.flowProcessDto.ProcessDto = _mapper.Map<ProcessEntity, ProcessDto>(flowEntity.processEntity);
                    result.flowProcessDto.ProcessDto.TotalPrice = result.flowProcessDto.ProcessDto.TotalPrice.Split(".")[0];
                }
                result.flowProcessDto.UserSalaryDtos = new List<FlowProcessUserSalaryModel>();

                if (flowEntity.flowProcessUserSalaryEntities != null)
                {
                    flowEntity.flowProcessUserSalaryEntities.ForEach((item) =>
                    {
                        result.flowProcessDto.UserSalaryDtos.Add(new FlowProcessUserSalaryModel
                        {
                            ID = item.Id,
                            maxWorkPerDay = item.User.MaxWorkPerDay,
                            maxWorkPerHour = item.User.MaxWorkPerHour,
                            salaryTypeID = item.User.SalaryTypeFK_ID != null ? item.User.SalaryTypeFK_ID.Value : 0,
                            UserID = item.UserID,
                            SumHours = item.User.SalaryTypeFK_ID == 14 ? item.SumHours : item.SumDays,
                            SalaryPerHours = item.SalaryPerHours,
                            UserName = item.User.FullName,
                            salaryTypeName = item.User.SalaryType.Title,
                            salary = item.User.SalaryTypeFK_ID == 14 ? item.User.SalaryPerHour.ToString() : (item.User.SalaryPerMonth).ToString()

                        });
                    });
                    if (result.flowProcessDto.UserSalaryDtos != null)
                        result.flowProcessDto.TotalSalaryPayment = result.flowProcessDto.UserSalaryDtos.Sum(z => Int64.Parse(z.salary));
                }
                if (flowEntity.wastageEntities != null)
                {
                    result.flowProcessDto.wastagesDto = new List<InitialBalancePoco>();
                    flowEntity.wastageEntities.ForEach((item) =>
                    {
                        result.flowProcessDto.wastagesDto.Add(new InitialBalancePoco
                        {
                            UnitName = item.InitialBalanceEntity.UnitMeasurement.Title,
                            ID = item.Id,
                            Price = item.InitialBalanceEntity.Price,
                            Count = item.Count,
                            UsedCount = flowEntity.processEntity.processBalanceEntities.Where(z => z.InitialBalanceID.Value == item.InitialBalanceEntityID).Sum(z => z.Count),
                            InitialBalanceID = item.InitialBalanceEntityID,
                            Title = flowEntity.processEntity.processBalanceEntities.Where(z => z.InitialBalanceID.Value == item.InitialBalanceEntityID).FirstOrDefault().initialBalanceEntity.Title,
                        });
                    });
                }
                if (flowEntity.IsNewMaterial == false)
                {
                    if (flowEntity.flowPorcessStockInitialEntities != null)
                    {
                        result.flowProcessDto.StockRoom_InitialBalanceDtos = new List<StockRoom_InitialBalanceDto>();
                        foreach (var item in flowEntity.flowPorcessStockInitialEntities)
                        {
                            var initialBalance = item.stockRoom_InitialBalanceEntity.InitialBalanceEntities;
                            var stockRoom = item.stockRoom_InitialBalanceEntity.StockRoomEntities;
                            result.flowProcessDto.StockRoom_InitialBalanceDtos.Add(new StockRoom_InitialBalanceDto
                            {
                                AddedCount = item.count,
                                InitialTitle = initialBalance.Title,
                                Title = stockRoom.Title,
                                CurrentCount = item.stockRoom_InitialBalanceEntity.CurrentCount,
                                Count = item.stockRoom_InitialBalanceEntity.Count,
                                PricePerUnit = initialBalance.Price.ToString().Split('.')[0]

                            });
                        }
                    }

                }
                else
                {
                    if (flowEntity.InitialBalanceEntity != null)
                    {
                        result.flowProcessDto.initialBalanceDto = _mapper.Map<InitialBalanceEntity, InitialBalancePoco>(flowEntity.InitialBalanceEntity);
                        result.flowProcessDto.initialBalanceDto.Count = flowEntity.InitialBalanceEntity.StockRoom_InitialBalanceEntity.Sum(z => z.Count);
                        if (flowEntity.InitialBalanceEntity.UnitMeasurement!=null)
                        result.flowProcessDto.initialBalanceDto.UnitName = flowEntity.InitialBalanceEntity.UnitMeasurement.Title;
                    }
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


        public FlowProcessVM Remove(long[] id)
        {
            var result = new FlowProcessVM();
            try
            {
                var entities = _repository.Get(id);
                foreach (var entity in entities)
                {
                    foreach (var flowProcessUserSalaryEntity in entity.flowProcessUserSalaryEntities.Where(z => z.IsEnabled == true).ToList())
                    {
                        flowProcessUserSalaryEntity.IsEnabled = false;
                    }

                    foreach (var item in entity.processEntity.processBalanceEntities)
                    {
                        item.stockRoom_InitialBalanceEntity.CurrentCount = item.stockRoom_InitialBalanceEntity.CurrentCount - item.Count;
                    }//برگرداندن مواد اولیه اضافه شده به انبار در اثر خروجی فرایند
                    if (entity.flowPorcessStockInitialEntities != null)
                    {
                        foreach (var item in entity.flowPorcessStockInitialEntities)
                        {
                            item.ModifiedById = this._jwtService.GetUserID();
                            item.IsEnabled = false;
                        }//حذف مقادیری که درون انبار اضافه گردیده بودند.
                    }
                    foreach (var item in entity.wastageEntities)
                    {
                        item.ModifiedById = this._jwtService.GetUserID();
                        item.IsEnabled = false;
                    }//حذف پرتی ها

                    if (entity.InitialBalanceEntity != null)
                    {
                        entity.ModifiedById = this._jwtService.GetUserID();
                        entity.InitialBalanceEntity.IsEnabled = false;
                    }//حذف مواد اولیه

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

        public FlowProcessVM Search(FlowProcessDto body)
        {
            var result = new FlowProcessVM();
            try
            {

                if (body.Row <= 0)
                    body.Row = 1;
                if (body.Page <= 0)
                    body.Page = 10;

                var expression = query(z => (
                                    (string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                                        string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                                            string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &
                                                    z.IsEnabled == true);

                var queryResult = _repository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _repository.GetQuery(expression);

                result.flowProcessDtos = _mapper.Map<List<FlowProcessEntity>, List<FlowProcessDto>>(queryResult);
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

        private Expression<Func<FlowProcessEntity, bool>> query(Expression<Func<FlowProcessEntity, bool>> expression)
        {
            return expression;
        }

        private FlowProcessEntity validationForInsert(FlowProcessDto body, InitialBalanceVM contractorTypes, ProcessVM processService)
        {

            if (processService.hasError)
                throw new CustomErrorException(processService.ErrorMessage, processService.Code);
            var foreignContractor = contractorTypes.generalParamterDtos.Where(z => z.Code == CommonUtility.GetParentType(ContractorTypes.Contractor)).FirstOrDefault();
            if (processService.processDto.ContractorTypeID == foreignContractor.ID)
            {
                if (string.IsNullOrEmpty(body.Hire))
                    throw new CustomErrorException(ConstantsValue.notHirePriceValidMsg, ConstantsValue.notHirePriceValidCode);
                body.SumLaborer = 0;
                body.SumHours = 0;
            }//چک می شود که نوع انجام فرایند از نوع پیمانار خارجی بوده است یا خیر؟
            else
            {
                if (body.UserSalaryDtos == null || body.UserSalaryDtos.Count <= 0)
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                //if (body.SumHours <= 0 || body.SumLaborer <= 0)
                //    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                body.Hire = null;
            }//حالتی است که نوع انجام کار توسط کارگر داخلی کارخانه باشد.


            var flowProcessEntity = new FlowProcessEntity();
            flowProcessEntity = _mapper.Map<FlowProcessDto, FlowProcessEntity>(body);
            if (processService.processDto.ContractorTypeID == foreignContractor.ID)
            {
                flowProcessEntity.FinalCost = (decimal.Parse(body.Hire) + decimal.Parse(processService.processDto.TotalPrice)).ToString();
            }//چک می شود که نوع انجام فرایند از نوع پیمانار خارجی بوده است ؟
            else
            {
                flowProcessEntity.TotalPrice = calculateUsersPrice(processService.processUserDtos, body.UserSalaryDtos).ToString();
                flowProcessEntity.FinalCost = (Int64.Parse(flowProcessEntity.TotalPrice) + decimal.Parse(processService.processDto.TotalPrice)).ToString(); ;
            }//حالتی است که نوع انجام کار توسط کارگر داخلی کارخانه باشد.
            return flowProcessEntity;
        }

        private long calculateUsersPrice(List<ProcessUserDto> processUserDtos, List<FlowProcessUserSalaryModel> UserSalaryDtos)
        {
            long totalSalary = 0;
            foreach (var item in processUserDtos)
            {
                var userSalaryDto = UserSalaryDtos.Where(z => z.UserID == item.UserID).FirstOrDefault();
                if (item.SalaryTypeFK_ID == 14)
                {
                    totalSalary = totalSalary + (long.Parse(item.salary) * userSalaryDto.SumHours);
                }
                else
                {
                    var price = (long.Parse(item.salary) );
                    totalSalary = totalSalary + price * (userSalaryDto.SumHours);
                }
            }
            return totalSalary;
        }
        public FlowProcessVM InsertToStack(FlowProcessDto body)
        {
            var result = new FlowProcessVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (_repository.GetQuery(z => z.Title == body.Title && z.IsEnabled == true) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateCode);

                var processService = _processService.GetByID(body.processID);
                var contractorTypes = _generalParameterService.GetGeneralParamterByParentCode(Common.EnumValues.ParentEnum.ProcessType);
                var foreignContractor = contractorTypes.generalParamterDtos.Where(z => z.Code == CommonUtility.GetParentType(ContractorTypes.Contractor)).FirstOrDefault();
                var internalContractors = contractorTypes.generalParamterDtos.Where(z => z.Code == CommonUtility.GetParentType(ContractorTypes.UsersContractors)).FirstOrDefault();

                var flowProcessEntity = validationForInsert(body, contractorTypes, processService);


                if (body.StockRoom_InitialBalanceDtos == null || body.StockRoom_InitialBalanceDtos.Count <= 0)
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);

                flowProcessEntity.CreatedById = this._jwtService.GetUserID();
                flowProcessEntity.IsNewMaterial = false;
                flowProcessEntity.processEntityID = body.processID;
                flowProcessEntity.IsForeignWorker = processService.processDto.ContractorTypeID == internalContractors.ID ? 15 : 0;
                _repository.Insert(flowProcessEntity);
                _repository.SaveChanges();
                var initialBalanceID = _stockRoom_BalanceService.GetByID(body.StockRoom_InitialBalanceDtos.FirstOrDefault().ID).stockRoomBalanceDto.InitialBalanceEntitiesFK_ID;
                _initialBalanceService.CalculateBalanceNewPrice(initialBalanceID, flowProcessEntity, body.StockRoom_InitialBalanceDtos.Sum(z => z.Count));
                foreach (var item in body.StockRoom_InitialBalanceDtos)
                {
                    var intialBalanceStock = _stockRoom_BalanceService.GetByID(item.ID);
                    if (intialBalanceStock.hasError == false)
                    {
                        var entity = new StockRoom_InitialBalanceDto
                        {
                            ID = intialBalanceStock.stockRoomBalanceDto.ID,
                            Count = item.Count,
                        };
                        _stockRoom_BalanceService.Increase(entity);
                        _flowProcessStockInitialRepository.Insert(new FlowProcessStockInitialEntity
                        {
                            count = item.Count,
                            FlowProcessEntity = flowProcessEntity,
                            stockRoom_InitialBalanceEntityID = entity.ID

                        });
                    }//درصورتی که برای مواد اولیه انتخابی درون خروجی فرایند درون انبار انتخابی رکوردی ذخیره شده باشد با استفاده از این تابع مقدار موجودی  اضافه میگردد.
                    else
                    {
                        var entity = new StockRoom_InitialBalanceDto
                        {
                            Count = item.Count,
                            StockRoom_InitialBalanceFK_ID = item.StockRoom_InitialBalanceFK_ID,
                            InitialBalanceEntitiesFK_ID = body.InitialBalanceID

                        };
                        _stockRoom_BalanceService.Insert(entity);
                        _flowProcessStockInitialRepository.Insert(new FlowProcessStockInitialEntity
                        {
                            CreatedById = this._jwtService.GetUserID(),
                            count = item.Count,
                            FlowProcessEntity = flowProcessEntity,
                            stockRoom_InitialBalanceEntityID = entity.ID

                        });
                    }//درصورتی که برای مواد اولیه انتخابی درون خروجی فرایند درون انبار انتخابی رکوردی ذخیره نشده باشد با استفاده از این تابع رکورد جدید اضافه میگردد.
                }


                if (processService.processDto.ContractorTypeID == internalContractors.ID)
                {
                    var flowUsersResult = _flowUsersSalaryService.Insert(body, flowProcessEntity, processService);
                    if (flowUsersResult.hasError)
                        throw new CustomErrorException(flowUsersResult.ErrorMessage, flowUsersResult.Code);
                }//در صورتی که نوع انجام فرایند داخلی باشد باید لیست ساعت کاری تمام کاربران دریافت و ثبت گردد.

                result.flowProcessDto = new FlowProcessDto();
                result.flowProcessDto.ID = flowProcessEntity.Id;
                _flowUsersSalaryService.SaveChanges();
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

        public FlowProcessVM InsertNewBalance(FlowProcessDto body, IFormFile file)
        {
            var result = new FlowProcessVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (_repository.GetQuery(z => z.Title == body.Title && z.IsEnabled == true) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateCode);
                var processService = _processService.GetByID(body.processID);
                var contractorTypes = _generalParameterService.GetGeneralParamterByParentCode(Common.EnumValues.ParentEnum.ProcessType);
                var foreignContractor = contractorTypes.generalParamterDtos.Where(z => z.Code == CommonUtility.GetParentType(ContractorTypes.Contractor)).FirstOrDefault();
                var internalContractors = contractorTypes.generalParamterDtos.Where(z => z.Code == CommonUtility.GetParentType(ContractorTypes.UsersContractors)).FirstOrDefault();

                var flowProcessEntity = validationForInsert(body, contractorTypes, processService);


                if (body.initialBalanceDto == null)
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (body.initialBalanceDto.StockRoom_InitialBalanceDto == null || body.initialBalanceDto.StockRoom_InitialBalanceDto.Count <= 0)
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                flowProcessEntity.CreatedById = this._jwtService.GetUserID();
                flowProcessEntity.IsNewMaterial = true;
                flowProcessEntity.processEntityID = body.processID;
                flowProcessEntity.IsForeignWorker = processService.processDto.ContractorTypeID == internalContractors.ID? 15:0;
                _repository.Insert(flowProcessEntity);
                _repository.SaveChanges();
                if (processService.processDto.ContractorTypeID == internalContractors.ID)
                {

                    var flowUsersResult = _flowUsersSalaryService.Insert(body, flowProcessEntity, processService);
                    if (flowUsersResult.hasError)
                        throw new CustomErrorException(flowUsersResult.ErrorMessage, flowUsersResult.Code);
                }//در صورتی که نوع انجام فرایند داخلی باشد باید لیست ساعت کاری تمام کاربران دریافت و ثبت گردد.

                _flowUsersSalaryService.SaveChanges();
                var resulInitial = _initialBalanceService.Insert(body.initialBalanceDto, file, flowProcessEntity);
                if (resulInitial.hasError == true)
                {
                    var ids = new List<long>();
                    ids.Add(body.processID);
                    Remove(ids.ToArray());
                    throw new CustomErrorException(resulInitial.ErrorMessage, resulInitial.Code);

                }

                result.flowProcessDto = new FlowProcessDto();
                result.flowProcessDto.ID = flowProcessEntity.Id;
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

        public FlowProcessVM GetAll()
        {
            var result = new FlowProcessVM();
            try
            {
                result.flowProcessDtos =
                    _mapper.Map<List<FlowProcessEntity>, List<FlowProcessDto>>(_repository.GetALL());
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

        public FlowProcessVM Remove(long id)
        {
            var result = new FlowProcessVM();
            try
            {
                var entity = _repository.Get(id);
                entity.ModifiedById = this._jwtService.GetUserID();
                entity.IsEnabled = false;
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

        public FlowProcessVM Active(long id)
        {
            var result = new FlowProcessVM();
            try
            {
                var entity = _repository.Get(id);
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

        public FlowProcessVM InsertWastages(FlowProcessDto body)
        {
            var result = new FlowProcessVM();
            try
            {
                var entity = _repository.Get(body.ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode); ;
                if (body.wastagesDto == null || body.wastagesDto.Count <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                var unitTypes = _generalParameterService.GetGeneralParamterByParentCode(ParentEnum.UnitMeasurement);
                foreach (var item in body.wastagesDto)
                {
                    var intialBalance = _initialBalanceService.GetByID(item.ID);
                    if (intialBalance.hasError)
                        throw new CustomErrorException(intialBalance.ErrorMessage, intialBalance.Code);
                    var wastageEntity = new WastageEntity();
                    if (!string.IsNullOrEmpty(item.Replace))
                    {
                        if (item.UnitMeaurementFK_ID == 0)
                        {
                            wastageEntity.UnitMeaurementFK_ID = unitTypes.generalParamterDtos[0].ID;
                        }
                        else
                            wastageEntity.UnitMeaurementFK_ID = item.UnitMeaurementFK_ID;
                        wastageEntity.Replace = item.Replace;
                    }

                    wastageEntity.CreatedById = this._jwtService.GetUserID();
                    wastageEntity.Count = item.Count;
                    wastageEntity.InitialBalanceEntityID = item.ID;
                    wastageEntity.FlowProcessEntityID = body.ID;
                    _wastageRepository.Insert(wastageEntity);
                }
                _wastageRepository.SaveChanges();
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
