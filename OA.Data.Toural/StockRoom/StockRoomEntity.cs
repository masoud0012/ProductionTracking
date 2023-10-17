using OA.Data.BaseEntities;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.StockRoom
{
    public class StockRoomEntity:BaseEntity
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<StockRoom_InitialBalanceEntity> StockRoom_InitialBalanceEntity { get; set; }

    }
}
