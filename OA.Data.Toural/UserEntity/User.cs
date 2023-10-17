using Microsoft.AspNetCore.Identity;
using OA.Data.BaseEntities;
using OA.Data.Toural.ControllersEntity;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.UserEntity
{
    public class User: IdentityUser<Int64>
    {
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return this.FirstName+" " + LastName; } set { value= LastName+" " + FirstName; } }
        public string Address { get; set; }
        public Int64 SalaryPerHour { get; set; }
        public Int64 SalaryPerMonth { get; set; }
        public Int64 MaxWorkPerHour { get; set; }
        public Int64 MaxWorkPerDay { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Int64? EmployeerTypeFK_ID { get; set; }
        public GeneralParameter EmployeerType { get; set; }
        public decimal Duration { get; set; }
        public Int64? SalaryTypeFK_ID { get; set; }
        public bool IsEnabled { get; set; }
        public GeneralParameter SalaryType { get; set; }
        public List<ProcessUserEntity> processUserEntities { get; set; }
        public List<ControllerUserEntity> ControllerUserEntities { get; set; }
        public List<ActionsUserEntity> ActionsUserEntities { get; set; }
        public List<OA.Data.Toural.LogEntity.LogEntity> LogEntities { get; set; }
    }
}
