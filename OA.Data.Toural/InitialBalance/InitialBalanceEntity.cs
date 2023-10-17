using OA.Data.BaseEntities;
using OA.Data.Toural.Job;
using OA.Data.Toural.Process;
using OA.Data.Toural.StockRoom;
using System;
using System.Collections.Generic;

namespace OA.Data.Toural.InitialBalance
{
    public class InitialBalanceEntity:BaseEntity
    {
        public string Title { get; set; }
        public Decimal Price { get; set; }
        public decimal PrevFlowPrice { get; set; }
        public string Code { get; set; }
        public Decimal TotalCostPriceLog { get; set; }
        public Decimal TotalUserCost { get; set; }
        public Decimal TotalPriceBalanceLastMonth { get; set; }
        public Decimal TotalCostPrice { get; set; }// این فیلد برای عملیات سرشکن می باشد. که مبلغ هزینه جاری ماه مورد نظر برای لاگ گیری در این قسمت ذخیره می گردد.
        public Decimal WeighProductInCalculation { get; set; }
        public decimal PriceBeforeCalculation { get; set; }
        public Int64 ProposedPrice { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public Int64? UnitMeaurementFK_ID { get; set; }
        public GeneralParameter UnitMeasurement { get; set; }
        public string ImageUri { get; set; }
        public Int64? TypeMaterialFK_ID { get; set; }
        public GeneralParameter TypeMaterial { get; set; }

        public Int64? CategoryTypeFK_ID { get; set; }
        public GeneralParameter CategoryType { get; set; }

        public List<StockRoom_InitialBalanceEntity> StockRoom_InitialBalanceEntity { get; set; }

        public List<ProcessBalanceEntity> processBalanceEntities { get; set; }
        public  List<WastageEntity> wastageEntities { get; set; }
        public Int64? flowProcessEntityID { get; set; }
        public FlowProcess.FlowProcessEntity flowProcessEntity { get; set; }

        public List<InitialBalanceJobEntity> InitialBalanceJobEntities { get; set; }

    }
}
