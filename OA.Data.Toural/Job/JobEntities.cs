using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Job
{
    public class JobEntities
    {
        public string JobEntityID { get; set; }
        public DateTime ExecutedDate { get; set; }
        public Decimal WeighProductInCalculation { get; set; }
        public Int64 TotalCost { get; set; }
        public decimal WeightInCalculation { get; set; }

        public List<CostJobEntity> CostJobEntities { get; set; }
        public List<InitialBalanceJobEntity> InitialBalanceJobEntities { get; set; }
    }
}
