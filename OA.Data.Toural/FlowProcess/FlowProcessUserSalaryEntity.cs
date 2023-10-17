using OA.Data.BaseEntities;
using OA.Data.Toural.Process;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.FlowProcess
{
    public  class FlowProcessUserSalaryEntity:BaseEntity
    {
        public Int64 FlowProcessEntityID { get; set; }
        public FlowProcessEntity FlowProcessEntity { get; set; }
        public Int64 UserID { get; set; }
        public User User { get; set; }
        public Int64 processUserEntityID { get; set; }
        public ProcessUserEntity processUserEntity { get; set; }
        public int SumLaborer { get; set; }
        public int SumHours { get; set; }
        public int SumDays { get; set; }
        public string SalaryPerDay { get; set; }
        public string SalaryPerHours { get; set; }
        public string TotalPrice { get; set; }
    }
}
