using OA.Data.BaseEntities;
using OA.Data.Toural.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.FlowProcess
{
    public  class FlowProcessStockInitialEntity:BaseEntity
    {
        public Int64 stockRoom_InitialBalanceEntityID { get; set; }
        public StockRoom_InitialBalanceEntity stockRoom_InitialBalanceEntity { get; set; }

        public Int64 FlowProcessEntityID { get; set; }
        public FlowProcessEntity FlowProcessEntity { get; set; }
        public Int64 count { get; set; }
    }
}
