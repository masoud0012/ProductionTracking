using AutoMapper;
using OA.Common.Utility;
using OA.Data.BaseEntities;
using OA.Data.Toural.ControllersEntity;
using OA.Data.Toural.Cost;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Job;
using OA.Data.Toural.LogEntity;
using OA.Data.Toural.Process;
using OA.Data.Toural.StockRoom;
using OA.Data.Toural.UserEntity;
using OA.Data.UserEntity;
using OA.Service_.Toural.ViewModels;
using OA.Service_.Toural.ViewModels.ControllVM;
using OA.Service_.Toural.ViewModels.Cost;
using OA.Service_.Toural.ViewModels.DashboardVM;
using OA.Service_.Toural.ViewModels.FlowProcess;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.Job;
using OA.Service_.Toural.ViewModels.Process;
using OA.Service_.Toural.ViewModels.StockRoom;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ControllerEntity, ControllerDto>().AfterMap<converMiladiDateToPersian>();
            CreateMap<ControllerDto, ControllerEntity>();

            CreateMap<ActionsEntity, ActionDto>().AfterMap<converMiladiDateToPersian>().AfterMap<GetControllerID>();
            CreateMap<ActionDto, ActionsEntity>();


            CreateMap<GeneralParameter, GeneralParamterPoco>().AfterMap<converMiladiDateToPersian>();
            CreateMap<GeneralParamterPoco, GeneralParameter>();

            CreateMap<InitialBalancePoco, InitialBalanceEntity>();
            CreateMap<InitialBalanceEntity, InitialBalancePoco>().AfterMap<converMiladiDateToPersian>();

            CreateMap<ProcessDto, ProcessEntity>().ForMember(x => x.IssueDate, opt => opt.Ignore()); 
            CreateMap<ProcessEntity, ProcessDto>().AfterMap<converMiladiDateToPersian>().AfterMap<converMiladiDateToPersianProcess>().AfterMap<converProcessMiladiDateToPersian>();

            CreateMap<ProcessDefinitionDto, ProcessDefinitionEntity>();
            CreateMap<ProcessDefinitionEntity, ProcessDefinitionDto>().AfterMap<converMiladiDateToPersian>();

            CreateMap<ProcessBalanceDto, ProcessBalanceEntity>();
            CreateMap<ProcessBalanceEntity, ProcessBalanceDto>().AfterMap<converMiladiDateToPersian>();

            CreateMap<FlowProcessDto, FlowProcessEntity>();
            CreateMap<FlowProcessEntity, FlowProcessDto>().AfterMap<converMiladiDateToPersian>();


            CreateMap<StockRoomDto, StockRoomEntity>();
            CreateMap<StockRoomEntity, StockRoomDto>().AfterMap<converMiladiDateToPersian>();

            CreateMap<ProcessUserDto, ProcessUserEntity>();
            CreateMap<ProcessUserEntity, ProcessUserDto>().AfterMap<converMiladiDateToPersian>();

            CreateMap<StockRoom_InitialBalanceDto, StockRoom_InitialBalanceEntity>();
            CreateMap<StockRoom_InitialBalanceEntity, StockRoom_InitialBalanceDto>();

            CreateMap<CostDto, CostEntity>();
            CreateMap<CostEntity, CostDto>().AfterMap<converMiladiDateToPersian>().AfterMap<converMiladiDateToPersianCost>();


            CreateMap<CostCategoryDto, CostCategoryEntity>();
            CreateMap<CostCategoryEntity, CostCategoryDto>().AfterMap<converMiladiDateToPersian>();

            CreateMap<JobDto, JobEntities>();
            CreateMap<JobEntities, JobDto>().AfterMap<converMiladiDateToPersianJob>();

            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>().ForMember(z => z.password, x => x.Ignore()).AfterMap<converMiladiDateToPersianUser>();

            CreateMap<RoleDto, RoleEntity>();
            CreateMap<RoleEntity, RoleDto>();

            CreateMap<LogEntity, LogDto>().AfterMap<ConvertDescriptionLog>();

        }
    }
    internal class ConvertDescriptionLog : IMappingAction<LogEntity, LogDto>
    {
        public void Process(LogEntity source, LogDto destination, ResolutionContext context)
        {
            string builder = (source.IsCreated == true ? "ایجاد " : "ویرایش ");
            string createdBy = source.User != null ? source.User.FullName : "";
            destination.Description = builder + source.Title + " در بخش " + source.OperationTitle + " توسط " + createdBy;
        }
    }

    internal class GetControllerID : IMappingAction<ActionsEntity, ActionDto>
    {
        public void Process(ActionsEntity source, ActionDto destination, ResolutionContext context)
        {
            destination.ControllerID = source.ControllerEntityID;
            if (source.ControllerEntity != null)
                destination.ControllerName = source.ControllerEntity.TitleFr;
        }
    }

    public class converProcessMiladiDateToPersian : IMappingAction<ProcessEntity, ProcessDto>
    {
        public void Process(ProcessEntity source, ProcessDto destination, ResolutionContext context)
        {
            destination.IssueDate = CommonUtility.ConvertMildiToPersian(source.IssueDate.Value);
            if (source.flowProcessEntities != null && source.flowProcessEntities.Count > 0)
                destination.Status = "بسته";
            else
                destination.Status = "باز";

        }
    }

    public class converMiladiDateToPersian : IMappingAction<BaseEntity, BasePoco>
    {
        public void Process(BaseEntity source, BasePoco destination, ResolutionContext context)
        {
            destination.createdDate = CommonUtility.ConvertMildiToPersian(source.AddedDate);
            if (source.ModifiedDate == null)
            {
                destination.IsModifedNew = false;
                destination.IsModified = false;
            }
            else if (source.ModifiedById ==0)
            {
                destination.modifiedDate = CommonUtility.ConvertMildiToPersian(source.ModifiedDate.Value);
                destination.IsModifedNew = false;
                destination.IsModified = false;
            }
            else
            {
                destination.modifiedDate = CommonUtility.ConvertMildiToPersian(source.ModifiedDate.Value);
                destination.IsModifedNew = true;
                destination.IsModified = true;
            }



        }
    }

    public class converMiladiDateToPersianJob : IMappingAction<JobEntities, JobDto>
    {
        public void Process(JobEntities source, JobDto destination, ResolutionContext context)
        {
            destination.ExecutedDate = CommonUtility.ConvertMildiToPersian(source.ExecutedDate);
            destination.JobID = source.JobEntityID;
        }
    }

    public class converMiladiDateToPersianUser : IMappingAction<User, UserDto>
    {
        public void Process(User source, UserDto destination, ResolutionContext context)
        {
            destination.createdDate = CommonUtility.ConvertMildiToPersian(source.AddedDate);
        }
    }

    public class converMiladiDateToPersianCost : IMappingAction<CostEntity, CostDto>
    {
        public void Process(CostEntity source, CostDto destination, ResolutionContext context)
        {
            if (source.CostDate != null)
                destination.CostDate = CommonUtility.ConvertMildiToPersian(source.CostDate.Value);
        }
    }

    public class converMiladiDateToPersianProcess : IMappingAction<ProcessEntity, ProcessDto>
    {
        public void Process(ProcessEntity source, ProcessDto destination, ResolutionContext context)
        {
            if (source.IssueDate != null)
                destination.IssueDatePersian = CommonUtility.ConvertMildiToPersian(source.IssueDate.Value);
        }
    }

    public class converMiladiDateToPersianRole : IMappingAction<RoleEntity, RoleDto>
    {
        public void Process(RoleEntity source, RoleDto destination, ResolutionContext context)
        {
            destination.createdDate = CommonUtility.ConvertMildiToPersian(source.AddedDate);
        }
    }
}
