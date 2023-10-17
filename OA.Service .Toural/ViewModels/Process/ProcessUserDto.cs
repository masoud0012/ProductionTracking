using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Process
{
    public class ProcessUserDto:BasePoco
    {
        public Int64 UserID { get; set; }

        public Int64 processID { get; set; }
        public string userName { get; set; }
        public string salary { get; set; }
        public Int64 salaryPerUnit { get; set; }
        public Int64 SalaryTypeFK_ID { get; set; }
        public string SalaryTypeName { get; set; }
        public Int64 MaxWorkPerHour { get; set; }
        public Int64 MaxWorkPerDay { get; set; }
    }
}
