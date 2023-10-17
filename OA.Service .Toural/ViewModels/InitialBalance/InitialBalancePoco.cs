using Microsoft.AspNetCore.Http;
using OA.Service_.Toural.ViewModels.DashboardVM;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.InitialBalance
{
    public class InitialBalancePoco:BasePoco
    { 
        public IFormFile FormFile { get; set; }
        public Int64 ProposedPrice { get; set; }
        public string FlowTitle { get; set; }
        public long[] ids { get; set; }
        public int Page { get; set; }
        public int Row { get; set; }
        public string Sort { get; set; }
        public long Count { get; set; }
        public long UsedCount { get; set; }
        public Decimal Price { get; set; }
        public string Address { get; set; }
        public string Replace { get; set; }
        public Int64 UnitMeaurementFK_ID { get; set; }
        public Int64 InitialBalanceID { get; set; }
        public Int64 TypeMaterialFK_ID { get; set; }
        public Int64 CategoryTypeFK_ID { get; set; }

        public string MaterialName { get; set; }
        public string UnitName { get; set; }
        public string CategoryName { get; set; }
        public Decimal WeighProductInCalculation { get; set; }
        public decimal WeightInCalculation { get; set; }

        public decimal PriceBeforeCalculation { get; set; }
        public List<StockRoom_InitialBalanceDto> StockRoom_InitialBalanceDto{ get; set; }
        public DashboardDto DashboardDto { get; set; }
    }
}
