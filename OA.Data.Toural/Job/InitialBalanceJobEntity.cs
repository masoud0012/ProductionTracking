using OA.Data.Toural.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Job
{
    public class InitialBalanceJobEntity
    {
        public string ID { get; set; }
        public Int64 InitialBalanceEntityID { get; set; }
        public InitialBalanceEntity InitialBalanceEntity { get; set; }

        public string JobEntityID { get; set; }
        public JobEntities JobEntitiy { get; set; }

        public decimal PriceBeforeCalculation { get; set; }
        public decimal WeightProductInCalculation { get; set; }
        public decimal NewPrice { get; set; }
        public decimal TotalPriceProducts { get; set; }

    }
}