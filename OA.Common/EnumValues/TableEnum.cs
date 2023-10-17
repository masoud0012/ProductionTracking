using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Common.EnumValues
{
    public enum TableEnum
    {
        [Description("ST-")]
        StockCode,
        [Description("BL-")]
        Balance,
        [Description("PD-")]
        ProcessDefinition,
        [Description("PS-")]
        Process,
        [Description("FP-")]
        FlowProcess,
        [Description("CT-")]
        Cost,
        [Description("CC-")]
        CostCategory,
    }
}
