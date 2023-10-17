using OA.Data.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessBalanceStockEntity:BaseEntity
    {
        public Int64 ProcessBalanceID { get; set; }
        public ProcessBalanceEntity processBalanceEntity { get; set; }
        public Int64 StockRoomID { get; set; }
        public StockRoom.StockRoom_InitialBalanceEntity stockRoom_InitialBalanceEntity { get; set; }

        public Int64 Count { get; set; }
        public string TotalPrice { get; set; }

    }
}
