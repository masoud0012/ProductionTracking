using OA.Data.BaseEntities;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.StockRoom
{
    public class StockRoom_InitialBalanceEntity:BaseEntity
    {
        public string Title { get; set; }
        public Int64? StockRoom_InitialBalanceFK_ID { get; set; }
        public StockRoomEntity StockRoomEntities { get; set; }

        public Int64? InitialBalanceEntitiesFK_ID { get; set; }
        public InitialBalanceEntity InitialBalanceEntities { get; set; }
        public List<ProcessBalanceEntity> processBalanceEntities { get; set; }
        public Int64 Count { get; set; }//موجودی اولیه
        public Int64 CurrentCount { get; set; }//موجودی فعلی
        public string PricePerUnit { get; set; }
        public string TotalPrice { get; set; }

        public List<FlowProcessStockInitialEntity> flowPorcessStockInitialEntities { get; set; }
        
    }
}
