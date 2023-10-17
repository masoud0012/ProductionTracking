using OA.Data.BaseEntities;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessBalanceEntity : BaseEntity
    {
        public Int64? InitialBalanceID { get; set; }
        public InitialBalanceEntity initialBalanceEntity { get; set; }

        public Int64? stockRoom_InitialBalanceID { get; set; }
        public StockRoom_InitialBalanceEntity stockRoom_InitialBalanceEntity { get; set; }
        public List<ProcessBalanceStockEntity> processBalanceStockEntities { get; set; }
        public Int64? processEntityID { get; set; }
        public ProcessEntity processEntity { get; set; }

        public Int64 Count { get; set; }

        public string TotalPrice { get; set; }

    }
}
