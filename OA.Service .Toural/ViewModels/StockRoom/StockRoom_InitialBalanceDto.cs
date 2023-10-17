using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.StockRoom
{
    public  class StockRoom_InitialBalanceDto
    {
        public Int64 ID { get; set; }
        public Int64 StockRoom_InitialBalanceFK_ID { get; set; }
        public Int64 InitialBalanceEntitiesFK_ID { get; set; }
        public Int64 processBalanceID { get; set; }
        public Int64 Count { get; set; }//موجودی اولیه
        public Int64 CurrentCount { get; set; }//موجودی فعلی
        public Int64 AddedCount { get; set; }
        public bool IsEnabled { get; set; }
        public string PricePerUnit { get; set; }
        public string TotalPrice { get; set; }
        public string Title { get; set; }
        public string InitialTitle { get; set; }
    }
}
