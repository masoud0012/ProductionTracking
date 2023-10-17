using OA.Data.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.InitialBalance
{
    public class WastageEntity:BaseEntity
    {
        public Int64 FlowProcessEntityID { get; set; }
        public FlowProcess.FlowProcessEntity FlowProcessEntity { get; set; }
        public string Replace { get; set; }
        public Int64 InitialBalanceEntityID { get; set; }
        public InitialBalanceEntity InitialBalanceEntity { get; set; }
        public Int64 Count { get; set; }
        public Int64? UnitMeaurementFK_ID { get; set; }
        public GeneralParameter UnitMeasurement { get; set; }

    }
}
