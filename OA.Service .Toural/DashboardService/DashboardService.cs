using AutoMapper;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Repo;
using OA.Repo.Troual.Contracts;
using OA.Repo.Troual.Contracts.ICost;
using OA.Repo.Troual.Contracts.IFlowProcess;
using OA.Repo.Troual.Contracts.InitialBalance;
using OA.Repo.Troual.Contracts.IProcess;
using OA.Service_.Toural.ViewModels.DashboardVM;
using OA.Service_.Toural.ViewModels.StockRoom;
using OA.Data.Toural.StockRoom;
using OA.Data.Toural.Cost;
using OA.Service_.Toural.ViewModels.Cost;
using OA.Data.Toural.FlowProcess;
using OA.Service_.Toural.ViewModels.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Data.Toural.Process;
using OA.Service_.Toural.ViewModels.Process;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Common.Exceptions;
using OA.Data.BaseEntities;
using OA.Repo.Troual.Contracts.ILogEntity;
using OA.Data.Toural.LogEntity;

namespace OA.Service_.Toural.DashboardService
{
    public class DashboardService: IDashboardService
    {
        private readonly IMapper _mapper;
        private ICostRepository CostRepository;
        private ICostCategoryRepository CostCategoryRepository;
        private readonly IFlowProcessRepository FlowProcessRepository;
        private readonly IInitialBalanceRepository initialBalanceRepository;
        private readonly IProcessRepository ProcessRepository;
        private readonly IStockRoomRepository stockRoomRepository;
        private readonly ILogEntityRepository logEntityRepository;
        
        private readonly IUserService userService;

        public DashboardService(IMapper mapper,
            IStockRoomRepository StockRoomRepository,
            ICostCategoryRepository CostCategoryRepository,
            IFlowProcessRepository flowProcessRepository,
            IInitialBalanceRepository initialBalanceRepository,
            ILogEntityRepository logEntityRepository,
            IUserService userService,
            IProcessRepository ProcessRepository,
            ICostRepository CostRepository)
        {
            this._mapper = mapper;
            this.userService = userService;
            this.stockRoomRepository = StockRoomRepository;
            this.CostRepository = CostRepository;
            this.CostCategoryRepository = CostCategoryRepository;
            this.FlowProcessRepository = flowProcessRepository;
            this.initialBalanceRepository = initialBalanceRepository;
            this.ProcessRepository = ProcessRepository;
            this.logEntityRepository = logEntityRepository;
        }

        public DashboardVM GetLastActivity(long UserID)
        {
            var result = new DashboardVM();
            try
            {
                var lastStock = stockRoomRepository.GetLastItem(UserID);
                var lastCostCategory = CostCategoryRepository.GetLastItem(UserID);
                var lastFlowItem = FlowProcessRepository.GetLastItem(UserID);
                var lastInitial = initialBalanceRepository.GetLastItem(UserID);
                var lastCost = CostRepository.GetLastItem(UserID);
                var lastProcess = ProcessRepository.GetLastItem(UserID);
                var userInfo = userService.GetUser(UserID);
                if (userInfo.hasError == true)
                {
                    throw new CustomErrorException("کاربری یافت نشد لطفا وارد سامانه شوید", "0");
                }
                result.StockRoomDto = _mapper.Map<StockRoomEntity, StockRoomDto>(lastStock);
                if (lastStock != null)
                {
                    result.StockRoomDto.DashboardDto =
                        generateDashboardDto(result.StockRoomDto.IsModifedNew, " انبار  ",
                                             userInfo.userDto.FullName, result.StockRoomDto.createdDate,
                                             result.StockRoomDto.modifiedDate, lastStock);
                }

                result.CostCategoryDto = _mapper.Map<CostCategoryEntity, CostCategoryDto>(lastCostCategory);
                if (lastCostCategory != null)
                {
                    result.CostCategoryDto.DashboardDto =
                        generateDashboardDto(result.CostCategoryDto.IsModifedNew, "سرفصل هزینه  ",
                                             userInfo.userDto.FullName, result.CostCategoryDto.createdDate,
                                             result.CostCategoryDto.modifiedDate, lastCostCategory);
                }

                result.FlowProcessDto = _mapper.Map<FlowProcessEntity, FlowProcessDto>(lastFlowItem);
                if (lastFlowItem != null)
                {
                    result.FlowProcessDto.DashboardDto =
                        generateDashboardDto(result.FlowProcessDto.IsModifedNew, "خروجی جریان ",
                                             userInfo.userDto.FullName, result.FlowProcessDto.createdDate,
                                             result.FlowProcessDto.modifiedDate, lastFlowItem);
                }



                result.InitialBalanceDto = _mapper.Map<InitialBalanceEntity, InitialBalancePoco>(lastInitial);
                if (lastInitial != null)
                {
                    result.InitialBalanceDto.DashboardDto =
                        generateDashboardDto(result.InitialBalanceDto.IsModifedNew, "مواد اولیه ",
                                             userInfo.userDto.FullName, result.InitialBalanceDto.createdDate,
                                             result.InitialBalanceDto.modifiedDate, lastInitial);
                }


                result.CostDto = _mapper.Map<CostEntity, CostDto>(lastCost);
                if (lastCost != null)
                {
                    result.CostDto.DashboardDto =
                        generateDashboardDto(result.CostDto.IsModifedNew, "هزینه",
                                             userInfo.userDto.FullName, result.CostDto.createdDate,
                                             result.CostDto.modifiedDate, lastCost);
                }


                result.ProcessDto = _mapper.Map<ProcessEntity, ProcessDto>(lastProcess);
                if (lastProcess != null)
                {
                    result.ProcessDto.DashboardDto = 
                        generateDashboardDto(result.ProcessDto.IsModifedNew, "فرایند",
                                             userInfo.userDto.FullName, result.ProcessDto.createdDate, 
                                             result.ProcessDto.modifiedDate, lastProcess);
                }
            }
            catch(CustomErrorException ex)
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

        private DashboardDto generateDashboardDto(bool isModifiedNew, string titleActivitiy,string FullName,string createdDate,string ModifiedDate,BaseEntity entity)
        {
            var dto = new DashboardDto();
            dto.ActivityName = isModifiedNew == true ? "ویرایش " + titleActivitiy + " با شناسه " + entity.Id:"ایجاد "+titleActivitiy+" با شناسه "+entity.Id;
            dto.FullName = FullName;
            dto.isCreated = !isModifiedNew;
            dto.DateActivity = isModifiedNew == true ? ModifiedDate : createdDate;
            dto.TimeActivity = isModifiedNew == true ? entity.ModifiedDate.Value.TimeOfDay.ToHHMM() : entity.AddedDate.TimeOfDay.ToHHMM();
            return dto;
        }


        private DashboardDto generateDashboardForActivitiesDto(bool isModifiedNew, string titleActivitiy,  string createdDate, string ModifiedDate, BaseEntity entity)
        {
            var usersInfo = isModifiedNew == true ? userService.GetUser(entity.ModifiedById) : userService.GetUser(entity.CreatedById);
            var dto = new DashboardDto();
            dto.ActivityName = isModifiedNew == true ? "ویرایش " + titleActivitiy + " با شناسه " + entity.Id : "ایجاد " + titleActivitiy + " با شناسه " + entity.Id;
            dto.FullName = usersInfo.userDto.FullName;
            dto.isCreated = !isModifiedNew;
            dto.DateActivity = isModifiedNew == true ? ModifiedDate : createdDate;
            dto.TimeActivity = isModifiedNew == true ? entity.ModifiedDate.Value.TimeOfDay.ToHHMM() : entity.AddedDate.TimeOfDay.ToHHMM();
            return dto;
        }

        public DashboardVM GetLastInitialBalance(long UserID)
        {
            var result = new DashboardVM();
            try
            {
                string query = "date:desc";
                var lastInitialBalance = initialBalanceRepository.GetQuery(z => z.IsEnabled == true, 1, 20, query).ToList();
                result.InitialBalanceDtos = _mapper.Map<List<InitialBalanceEntity>,List<InitialBalancePoco>>(lastInitialBalance);
                foreach (var item in result.InitialBalanceDtos)
                {
                    item.DashboardDto = generateDashboardForActivitiesDto(item.IsModifedNew, "مواد اولیه " + item.Title, item.createdDate, item.modifiedDate, lastInitialBalance.FirstOrDefault(z => z.Id == item.ID));
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


        public DashboardVM GetLastStockActivity(long UserID)
        {
            var result = new DashboardVM();
            try
            {
                string query = "date:desc";
                var lastInitialBalance = stockRoomRepository.GetQuery(z => z.IsEnabled == true, 1, 20, query).ToList();
                result.StockRoomDtos = _mapper.Map<List<StockRoomEntity>, List<StockRoomDto>>(lastInitialBalance);
                foreach (var item in result.StockRoomDtos)
                {
                    item.DashboardDto = generateDashboardForActivitiesDto(item.IsModifedNew,  item.Title, item.createdDate, item.modifiedDate, lastInitialBalance.FirstOrDefault(z => z.Id == item.ID));
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

        public DashboardVM GetProcessChart()
        {
            var result = new DashboardVM();
            try
            {
                var openProces = ProcessRepository.GetQuery(z => z.IsEnabled == true && z.flowProcessEntities.Count == 0);
                result.dashboardDto = new DashboardDto();
                result.dashboardDto.Count = ProcessRepository.GetQuery(z => z.IsEnabled == true && z.flowProcessEntities.Count > 0);
                result.dashboardDto.OpenProcessCount = openProces;
            }
            catch (CustomErrorException ex)
            {
                result.ErrorMessage = ex.errorMessage;
                result.Code = ex.Code;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DashboardVM GetCostChart()
        {
            var result = new DashboardVM();
            try
            {
                var costCategoryEntities = CostCategoryRepository.GetQueryData(z => z.IsEnabled == true).ToList(); 
                result.dashboardDto = new DashboardDto();
                result.dashboardDto.CostCategoryDtos = new List<CostCategoryDto>();
                foreach (var item in costCategoryEntities)
                {
                    result.dashboardDto.CostCategoryDtos.Add(new CostCategoryDto
                    {
                        TotalPrice = item.costEntities.Sum(z=>z.CostAmount).ToString(),
                        CostCount = item.costEntities.Count,
                        Title = item.Title
                    }); ;
                }

            }
            catch (CustomErrorException ex)
            {
                result.ErrorMessage = ex.errorMessage;
                result.Code = ex.Code;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DashboardVM GetLogEntities(DashboardDto body)
        {
            var result = new DashboardVM();
            try
            {
                var logEntities = logEntityRepository.GetQueryData(z => z.ID > 0, body.Page, 20).ToList();
                result.LogDtos = _mapper.Map<List<LogEntity>, List<LogDto>>(logEntities);
                result.numberRows = logEntityRepository.GetQuery(z => z.ID > 0);
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
    }
}
