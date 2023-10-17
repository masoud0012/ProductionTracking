using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.FlowProcess
{
    public class FlowProcessUserSalaryModel:BasePoco
    {
        public Int64 UserID { get; set; }
        public int SumLaborer { get; set; }
        public int SumHours { get; set; }
        public Int64 maxWorkPerDay { get; set; }
        public Int64 maxWorkPerHour { get; set; }
        public string SalaryPerHours { get; set; }
        public string TotalPrice { get; set; }
        public string UserName { get; set; }
        public Int64 salaryTypeID { get; set; }
        public string salaryTypeName { get; set; }
        public string salary { get; set; }
    }
}
