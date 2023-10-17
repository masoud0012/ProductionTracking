using AutoMapper;
using OA.Common.Constants;
using OA.Common.EnumValues;
using OA.Common.Exceptions;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.InitialBalance;
using OA.Repo.Troual.Contracts.IProcess;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ViewModels.Process;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OA.Data.Toural.InitialBalance;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.Contracts.FlowProcess;
using Microsoft.Extensions.DependencyInjection;
using OA.Service_.Toural.Contracts.PDFService;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Common.Utility;

namespace OA.Service_.Toural.Process
{
    public class ProcessService : IProcessService
    {
        private readonly IMapper _mapper;
        private readonly IProcessRepository _repository;
        private readonly IProcessDefinitionRepository _definitionRepository;
        private readonly IInitialBalanceRepository _initialBalanceRepository;
        private readonly IGeneralParameterService _generalParameterService;
        private readonly IProcessBalanceRepository _processBalanceRepository;
        private readonly IProcessUserRepository _processUserRepository;
        private readonly IStockRoom_InitialBalanceRepository _stockRoom_InitialBalanceRepository;
        private readonly IPdfService _pdfService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;
        private readonly IJWService _jwtService;
        public ProcessService(IProcessRepository repository,
                              IInitialBalanceRepository initialBalanceRepository,
                              IProcessBalanceRepository processBalanceRepository,
                              IGeneralParameterService _generalParameterService,
                              IStockRoom_InitialBalanceRepository stockRoom_InitialBalanceRepository,
                              IProcessUserRepository processUserRepository,
                              IProcessDefinitionRepository definitionRepository,
                              IPdfService pdfService,
                              IUserService userService,
                               IServiceProvider serviceProvider,
                              IJWService jwtService,
                              IMapper mapper)
        {
            this._initialBalanceRepository = initialBalanceRepository;
            this._processUserRepository = processUserRepository;
            this._processBalanceRepository = processBalanceRepository;
            this._repository = repository;
            this._mapper = mapper;
            this._pdfService = pdfService;
            this._definitionRepository = definitionRepository;
            this._generalParameterService = _generalParameterService;
            this._stockRoom_InitialBalanceRepository = stockRoom_InitialBalanceRepository;
            this._serviceProvider = serviceProvider;
            _userService = userService;
            this._jwtService = jwtService;
        }

        public ProcessVM Edit(ProcessDto body)
        {
            var result = new ProcessVM();
            try
            {
                var entity = _repository.Get(body.ID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);

                List<UserDto> userContractors = new List<UserDto>();
                if (string.IsNullOrEmpty(body.IssueDate) || body.ContractorTypeID == null || string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var contractorType = _generalParameterService.GetByID(body.ContractorTypeID.Value);
                if (contractorType.generalParamterDto == null)
                    throw new CustomErrorException(ConstantsValue.notContractorNotValidMsg, ConstantsValue.notContractorNotValidCode);
                if (_definitionRepository.Get(body.ProcessDefinitionID) == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);

                if (contractorType.generalParamterDto.Code == CommonUtility.GetParentType(ContractorTypes.Contractor))//چک میکنم که آیا نوع پیمانکار از نوع خارجی است
                {
                    if (string.IsNullOrEmpty(body.ContractorFullName))//اگر خارجی بود و مقدار نام و نام خانوادگی پیمانکار خارجی وارد نشده بود خطا میدهد
                        throw new CustomErrorException(ConstantsValue.notContractorFullNameNotValidMsg, ConstantsValue.notContractorFullNameNotValidCode);
                }
                else if (contractorType.generalParamterDto.Code == CommonUtility.GetParentType(ContractorTypes.UsersContractors))//چک میکنم که آیا نوع پیمانکار از نوع داخلی است
                {
                    body.ContractorFullName = null;
                    if (body.UserContractorID.Length == 0)//در صورتی که پیمانکار داخلی باشد ، می بایست لیست کاربران پیمانکار داخلی انتخاب گردد.
                    {
                        throw new CustomErrorException(ConstantsValue.notUserContractorFullNameNotValidMsg, ConstantsValue.notUserContractorFullNameNotValidCode);
                    }
                    var users = _userService.GetUsers(body.UserContractorID);
                    if (users.hasError == true)
                        throw new CustomErrorException(users.ErrorMessage, users.Code);
                    userContractors = users.userDtos;
                }
                if (_repository.GetQuery(z => z.Title.Equals(body.Title) & z.Id != body.ID) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                entity.ModifiedById =  this._jwtService.GetUserID();
                entity.IsEnabled = true;
                entity.IsFinalStep = body.IsFinalStep;
                entity.processDefinitionEntityID = body.ProcessDefinitionID;
                entity.IssueDate = DateTime.Parse(body.IssueDate);
                entity.ContractorFullName = body.ContractorFullName;
                entity.ContractorTypeID = body.ContractorTypeID;
                entity.Title = body.Title;
                entity.Description = body.Description;
                _repository.Update(entity);
                _repository.SaveChanges();
                result.processDto = new ProcessDto();
                result.processDto.ID = entity.Id;


                if (contractorType.generalParamterDto.Code == CommonUtility.GetParentType(ContractorTypes.UsersContractors))
                {
                    var processUserEntities = _processUserRepository.GetQuery(z => z.processEntityID == entity.Id, 1, 10000);
                    foreach (var item in processUserEntities)
                    {
                        if (!userContractors.Any(z => z.ID == item.UserID))
                        {
                            _processUserRepository.Delete(item);
                        }
                    }//درا ین متد چک میشود که خواهان حذف کاربری هستیم یا خیر.

                    foreach (var item in userContractors)
                    {
                        if (!processUserEntities.Any(z => z.UserID == item.ID))
                        {
                            ProcessUserEntity processUserEntity = new ProcessUserEntity();
                            processUserEntity.UserID = item.ID;
                            processUserEntity.processEntityID = entity.Id;
                            _processUserRepository.Insert(processUserEntity);
                        }//در صورتیکه خوهان اضافه کردن کاربری به لیست کارگران داخلی باشیم این متد اجرا خواهد گردید.
                    }
                    _processUserRepository.SaveChanges();
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


        public ProcessVM GetByID(long ID)
        {
            var result = new ProcessVM();
            try
            {
                var userContractors = new List<ProcessUserDto>();
                var processEntity = _repository.Get(ID);
                result.processDto = _mapper.Map<ProcessEntity, ProcessDto>(processEntity);
                if (result.processDto.TotalPrice.Contains('.'))
                    result.processDto.TotalPrice = result.processDto.TotalPrice.Split('.')[0];
                else if(result.processDto.TotalPrice.Contains('/'))
                    result.processDto.TotalPrice = result.processDto.TotalPrice.Split('/')[0];
                result.processBalanceDtos = _mapper.Map<List<ProcessBalanceEntity>, List<ProcessBalanceDto>>(processEntity.processBalanceEntities);
                result.initialBalanceDtos = new List<ViewModels.InitialBalance.InitialBalancePoco>();
                result.processDto.DaysInMonth = _generalParameterService.getCurrentDaysOfMonth();
                if (result.processBalanceDtos != null)
                    if (result.processBalanceDtos.Count > 0)
                    {
                        var initialIds = result.processBalanceDtos.DistinctBy(z => z.InitialBalanceID).Select(z => z.InitialBalanceID).ToArray();
                        var initialBalances = _initialBalanceRepository.Get(initialIds);
                        result.initialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>, List<InitialBalancePoco>>(initialBalances);
                        foreach (var item in initialIds)
                        {
                            var foundItem = result.initialBalanceDtos.FirstOrDefault(z => z.ID == item);
                            foundItem.UsedCount = result.processBalanceDtos.Where(z => z.InitialBalanceID == item).Sum(z => z.Count);
                            foundItem.UnitName = initialBalances.FirstOrDefault(z => z.Id == item).UnitMeasurement.Title;
                        }
                    }
                if (processEntity.UserContractors != null)
                    if (processEntity.UserContractors.Count > 0)
                    {
                        long[] userIds = processEntity.UserContractors.Select(z => z.UserID.Value).ToArray();
                        var usersDb = _userService.GetUsers(userIds);
                        var salaryInfos = _generalParameterService.GetGeneralParamterByParentCode(ParentEnum.SalaryType);
                        foreach (var item in processEntity.UserContractors)
                        {
                            var userInfo = usersDb.userDtos.Where(z => z.ID == item.UserID.Value).FirstOrDefault();
                            var userItem = new ProcessUserDto();
                            userItem.ID = item.Id;
                            userItem.UserID = item.UserID.Value;
                            userItem.userName = userInfo.FullName;
                            userItem.processID = item.Id;
                            userItem.SalaryTypeFK_ID = userInfo.SalaryTypeFK_ID;
                            if (userInfo.SalaryTypeFK_ID == 14)
                            {
                                userItem.salary = userInfo.SalaryPerHour.ToString();
                                userItem.MaxWorkPerHour = userInfo.MaxWorkPerHour;
                                userItem.salaryPerUnit = userInfo.SalaryPerHour;
                            }
                            else
                            {
                                userItem.salary = userInfo.SalaryPerMonth.ToString();
                                userItem.salaryPerUnit = userInfo.SalaryPerMonth ;
                                userItem.MaxWorkPerDay = userInfo.MaxWorkPerDay;
                            }
                            userItem.SalaryTypeFK_ID = userInfo.SalaryTypeFK_ID;
                            userItem.SalaryTypeName = salaryInfos.generalParamterDtos.Where(z => z.ID == userItem.SalaryTypeFK_ID).FirstOrDefault().Title;
                            userContractors.Add(userItem);
                        }
                        result.processUserDtos = new List<ProcessUserDto>();
                        result.processUserDtos.AddRange(userContractors);
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


        public ProcessVM Remove(long[] id)
        {
            var result = new ProcessVM();
            try
            {
                foreach (var itemID in id)
                {
                    var entity = _repository.Get(itemID);
                    var processUserEntities = entity.UserContractors;
                    foreach (var item in processUserEntities)
                    {
                        _processUserRepository.Remove(item);
                    }

                    var processBalanceEntities = entity.processBalanceEntities;
                    var stockRoomBalanceIEntities = entity.processBalanceEntities.ToList();
                    var InitialBalanceEntities = _stockRoom_InitialBalanceRepository.Get(stockRoomBalanceIEntities.Select(z => z.stockRoom_InitialBalanceID.Value).ToArray());
                    foreach (var item in InitialBalanceEntities)
                    {
                        item.CurrentCount = item.CurrentCount + stockRoomBalanceIEntities.Where(z => z.stockRoom_InitialBalanceID == item.Id).FirstOrDefault().Count;
                        _stockRoom_InitialBalanceRepository.Update(item);
                    }
                    foreach (var item in processBalanceEntities)
                    {
                        item.ModifiedById = this._jwtService.GetUserID();
                        item.IsEnabled = false;
                    }
                    entity.ModifiedById = this._jwtService.GetUserID();
                    entity.IsEnabled = false;
                    _repository.SaveChanges();
                    if (entity.flowProcessEntities != null)
                        if (entity.flowProcessEntities.Count > 0)
                        {
                            var flowProcessService = _serviceProvider.GetRequiredService<IFlowProcessService>();
                            flowProcessService.Remove(entity.flowProcessEntities.Select(z => z.Id).ToArray());

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

        public ProcessVM Search(ProcessDto body)
        {
            var result = new ProcessVM();
            try
            {

                if (body.Row <= 0)
                    body.Row = 1;
                if (body.Page <= 0)
                    body.Page = 10;


                var expression = query(z => (
                    (string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                    (string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title)) ||
                    (string.IsNullOrEmpty(body.Title) || z.ContractorName.Contains(body.Title)) ||
                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &
                                    z.IsEnabled == true);

                if (body.Status == null)
                    body.Status = "0";
                var queryResult = _repository.GetQuery(expression, body.Page, body.Row, body.Sort,Int32.Parse(body.Status));
                var countTable = _repository.GetQuery(expression);

                result.processDtos = _mapper.Map<List<ProcessEntity>, List<ProcessDto>>(queryResult);
                result.numberRows = countTable;
                foreach (var item in result.processDtos)
                {
                    var queryEntity = queryResult.Where(z => z.Id == item.ID).ToList().FirstOrDefault();
                    item.IssueDate = item.IssueDate;
                    item.ContractorTypeName = queryEntity.ContractorType.Title;
                    item.ProcessDefinitionTitle = queryResult.Where(z => z.Id == item.ID).Select(z => z.processDefinitionEntity).FirstOrDefault().Title;
                    item.UserContractorID = queryEntity.UserContractors.Select(z => z.Id).ToArray();
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

        private Expression<Func<ProcessEntity, bool>> query(Expression<Func<ProcessEntity, bool>> expression)
        {
            return expression;
        }

        public ProcessVM Insert(ProcessDto body)
        {
            var result = new ProcessVM();
            try
            {
                List<UserDto> userContractors = new List<UserDto>();

                if (string.IsNullOrEmpty(body.IssueDate) || body.ContractorTypeID == null || string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var contractorType = _generalParameterService.GetByID(body.ContractorTypeID.Value);
                if (contractorType.generalParamterDto == null)
                    throw new CustomErrorException(ConstantsValue.notContractorNotValidMsg, ConstantsValue.notContractorNotValidCode);
                if (_repository.GetQuery(z => z.Title.Equals(body.Title) && z.IsEnabled == true) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                if (_definitionRepository.Get(body.ProcessDefinitionID) == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);

                if (contractorType.generalParamterDto.Code == CommonUtility.GetParentType(ContractorTypes.Contractor))//چک میکنم که آیا نوع پیمانکار از نوع خارجی است
                {
                    if (string.IsNullOrEmpty(body.ContractorFullName))//اگر خارجی بود و مقدار نام و نام خانوادگی پیمانکار خارجی وارد نشده بود خطا میدهد
                        throw new CustomErrorException(ConstantsValue.notContractorFullNameNotValidMsg, ConstantsValue.notContractorFullNameNotValidCode);
                }
                else if (contractorType.generalParamterDto.Code == CommonUtility.GetParentType(ContractorTypes.UsersContractors))//چک میکنم که آیا نوع پیمانکار از نوع داخلی است
                {

                    body.ContractorFullName = null;
                    if (body.UserContractorID.Length == 0)//در صورتی که پیمانکار داخلی باشد ، می بایست لیست کاربران پیمانکار داخلی انتخاب گردد.
                    {
                        throw new CustomErrorException(ConstantsValue.notUserContractorFullNameNotValidMsg, ConstantsValue.notUserContractorFullNameNotValidCode);
                    }
                    var users = _userService.GetUsers(body.UserContractorID);
                    if (users.hasError == true)
                        throw new CustomErrorException(users.ErrorMessage, users.Code);
                    userContractors = users.userDtos;
                }


                var entity = _mapper.Map<ProcessDto, ProcessEntity>(body);
                body.ID = 0;
                entity = _mapper.Map<ProcessDto, ProcessEntity>(body);
                entity.processDefinitionEntityID = body.ProcessDefinitionID;
                entity.CreatedById = this._jwtService.GetUserID();
                entity.IsFinalStep = body.IsFinalStep;
                entity.ContractorTypeID = body.ContractorTypeID;
                entity.IssueDate = DateTime.Parse(body.IssueDate);
                entity.AddedDate = DateTime.Now;
                entity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.Process) + _repository.LastInsertedID();
                _repository.Insert(entity);
                _repository.SaveChanges();
                result.processDto = new ProcessDto();
                result.processDto.ID = entity.Id;

                if (contractorType.generalParamterDto.Code == CommonUtility.GetParentType(ContractorTypes.UsersContractors))
                {
                    foreach (var item in userContractors)
                    {
                        ProcessUserEntity processUserEntity = new ProcessUserEntity();
                        processUserEntity.UserID = item.ID;
                        processUserEntity.processEntityID = entity.Id;
                        _processUserRepository.Insert(processUserEntity);
                    }
                    _processUserRepository.SaveChanges();
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
            var result = new ProcessVM();
            try
            {
                result.processDtos =
                    _mapper.Map<List<ProcessEntity>, List<ProcessDto>>(_repository.GetALL());
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

        public ProcessVM Remove(long id)
        {
            var result = new ProcessVM();
            try
            {
                var entity = _repository.Get(id);
                var processUserEntities = entity.UserContractors;
                foreach (var item in processUserEntities)
                {
                    _processUserRepository.Remove(item);
                }

                var processBalanceEntities = entity.processBalanceEntities;
                var stockRoomBalanceIEntities = entity.processBalanceEntities.ToList();
                var InitialBalanceEntities = _stockRoom_InitialBalanceRepository.Get(stockRoomBalanceIEntities.Select(z => z.stockRoom_InitialBalanceID.Value).ToArray());
                var userid= entity.ModifiedById = this._jwtService.GetUserID();
                foreach (var item in InitialBalanceEntities)
                {
                    item.CurrentCount = item.CurrentCount - stockRoomBalanceIEntities.Where(z => z.stockRoom_InitialBalanceID == item.Id).FirstOrDefault().Count;
                    item.ModifiedById =userid;
                    _stockRoom_InitialBalanceRepository.Update(item);
                }
                foreach (var item in processBalanceEntities)
                {
                    item.ModifiedById = userid;
                    item.IsEnabled = false;
                }
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

        public ProcessVM Active(long id)
        {
            var result = new ProcessVM();
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

        public ProcessVM InsertBalance(ProcessBalanceDto body)
        {
            var result = new ProcessVM();
            try
            {
                if (body.stockRoom_InitialBalanceDtos == null || body.stockRoom_InitialBalanceDtos.Count <= 0 || body.ID <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                var processEntity = _repository.Get(body.ID);
                if (processEntity == null) { 
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                }
                var errorMessage = new List<string>();
                bool hasError = false;
                decimal processTotalPrice = 0;
                foreach (var item in body.stockRoom_InitialBalanceDtos)
                {
                    var initialBalanceEntity = _initialBalanceRepository.Get(item.InitialBalanceEntitiesFK_ID);
                    var stockBalanceEntity = _stockRoom_InitialBalanceRepository.Get(item.ID);

                    if (initialBalanceEntity == null)
                    {
                        errorMessage.Add("error ");
                        hasError = true;
                    }
                    if (stockBalanceEntity == null)
                    {
                        errorMessage.Add("error ");
                        hasError = true;
                    }
                    if (item.Count > stockBalanceEntity.CurrentCount)
                    {
                        errorMessage.Add("بیش از ظرفیت انبار انتخاب نموده اید.");
                        hasError = true;
                    }
                    if (hasError == true)
                    {
                        Remove(processEntity.Id);
                    }
                    else
                    {
                        var totalPrice = item.Count * initialBalanceEntity.Price;
                        processTotalPrice = processTotalPrice + totalPrice;
                        var entity = new ProcessBalanceEntity();
                        entity.TotalPrice = totalPrice.ToString();
                        entity.processEntity = processEntity;
                        entity.processEntityID = processEntity.Id;
                        entity.CreatedById = this._jwtService.GetUserID();
                        entity.initialBalanceEntity = initialBalanceEntity;
                        entity.stockRoom_InitialBalanceID = stockBalanceEntity.Id;
                        entity.stockRoom_InitialBalanceEntity = stockBalanceEntity;
                        entity.Count = item.Count;
                        _processBalanceRepository.Insert(entity);
                        stockBalanceEntity.CurrentCount = stockBalanceEntity.CurrentCount - item.Count;
                    }
                }
                processEntity.TotalPrice = processTotalPrice;
                _repository.SaveChanges();

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


        public ProcessVM EditBalance(ProcessBalanceDto body)
        {
            var result = new ProcessVM();
            try
            {
                if (body.stockRoom_InitialBalanceDtos == null || body.stockRoom_InitialBalanceDtos.Count <= 0 || body.ID <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                var processEntity = _repository.Get(body.ID);
                if (processEntity == null)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);
                var errorMessage = new List<string>();
                bool hasError = false;
                var userID =  this._jwtService.GetUserID();
                decimal processTotalPrice = 0;
                foreach (var item in body.stockRoom_InitialBalanceDtos)
                {
                    var initialBalanceEntity = _initialBalanceRepository.Get(item.InitialBalanceEntitiesFK_ID);
                    var stockBalanceEntity = _stockRoom_InitialBalanceRepository.Get(item.ID);

                    if (initialBalanceEntity == null)
                    {
                        errorMessage.Add("error ");
                        hasError = true;
                    }
                    if (stockBalanceEntity == null)
                    {
                        errorMessage.Add("error ");
                        hasError = true;
                    }
                    if (item.Count > stockBalanceEntity.CurrentCount)
                    {
                        errorMessage.Add("بیش از ظرفیت انبار انتخاب نموده اید.");
                        hasError = true;
                    }
                    if (hasError == true)
                    {

                    }
                    else
                    {
                        var oldProcessBalanceItem = processEntity.processBalanceEntities.Where(z => z.InitialBalanceID == item.InitialBalanceEntitiesFK_ID&&z.stockRoom_InitialBalanceID==item.ID&&z.IsEnabled==true).FirstOrDefault();
                        if (oldProcessBalanceItem != null)
                        {
                            var processBalanceEntity = oldProcessBalanceItem;
                            var totalPrice = item.Count * initialBalanceEntity.Price;
                            processTotalPrice = processTotalPrice + totalPrice;
                            oldProcessBalanceItem.TotalPrice = totalPrice.ToString();
                            oldProcessBalanceItem.ModifiedById = userID;
                            var diffCount = item.Count - oldProcessBalanceItem.Count;
                            oldProcessBalanceItem.Count = item.Count ;
                            _processBalanceRepository.Update(processBalanceEntity);
                            stockBalanceEntity.CurrentCount = stockBalanceEntity.CurrentCount - diffCount;
                        }//در این قسمت موجودی به ازای محصول درون انبار ذخیره خواهد شد.
                        else
                        {
                            var totalPrice = item.Count * initialBalanceEntity.Price;
                            var entity = new ProcessBalanceEntity();
                            entity.TotalPrice = totalPrice.ToString();
                            processTotalPrice = processTotalPrice + totalPrice;
                            entity.processEntity = processEntity;
                            entity.IsEnabled = true;
                            entity.processEntityID = processEntity.Id;
                            entity.initialBalanceEntity = initialBalanceEntity;
                            entity.ModifiedById = userID;
                            entity.stockRoom_InitialBalanceID = stockBalanceEntity.Id;
                            entity.stockRoom_InitialBalanceEntity = stockBalanceEntity;
                            entity.Count = item.Count;
                            _processBalanceRepository.Insert(entity);
                            stockBalanceEntity.CurrentCount = stockBalanceEntity.CurrentCount - item.Count;
                        }//در این قسمت میخواهیم موجودی جدید به انبار به ازای محصول اضافه کردد.
                    }
                }
                foreach (var removedItem in processEntity.processBalanceEntities)
                {
                    if (!body.stockRoom_InitialBalanceDtos.Any(z => z.InitialBalanceEntitiesFK_ID == removedItem.InitialBalanceID && removedItem.stockRoom_InitialBalanceID == z.ID))
                    {
                        removedItem.IsEnabled = false;
                        removedItem.stockRoom_InitialBalanceEntity.CurrentCount = removedItem.stockRoom_InitialBalanceEntity.CurrentCount + removedItem.Count;
                    }
                }
                if (hasError == false)
                {
                    processEntity.TotalPrice = processTotalPrice;
                    _repository.SaveChanges();
                    _processBalanceRepository.SaveChanges();
                }
                else
                {
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode, errorMessage);
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
                throw ex;
            }
            return result;
        }

        public ProcessVM RolBackProcess(long id)
        {
            var result = new ProcessVM();
            try
            {
                var entity = _repository.Get(id);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.ModifiedById = this._jwtService.GetUserID();
                _repository.Delete(entity);
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

        public ProcessDto GetUserContractors(long Id)
        {
            var result = new ProcessDto();

            var queryResult = _processUserRepository.GetByProcessID(Id);
            result.UserContractorID = queryResult.Select(z => z.UserID.Value).ToList().ToArray();

            return result;
        }

        public ProcessDto GetProcessBalances(long Id)
        {
            var result = new ProcessDto();

            var queryResult = _processBalanceRepository.GetProcessBalances(Id);
            result.processBalanceDtos = _mapper.Map<List<ProcessBalanceEntity>, List<ProcessBalanceDto>>(queryResult);
            return result;
        }

        public ProcessVM GetPDF(long Id)
        {
            ProcessVM result = new ProcessVM();

            try
            {
                var processDto = GetByID(Id);
                if (processDto.hasError == true)
                {
                    throw new CustomErrorException(result.ErrorMessage, result.ErrorMessage);
                }
                result = _pdfService.ProcessPDF(processDto.processDto);
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
