using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Job
{
    public class JobDto:BasePoco
    {
        public string JobID { get; set; }
        public string ExecutedDate { get; set; }
        public Decimal WeighProductInCalculation { get; set; }
        public Int64 TotalCost { get; set; }
        public decimal WeightInCalculation { get; set; }
    }
}
