using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Common.EnumValues
{
    public enum ParentEnum
    {
        [Description("0001")]
        UnitMeasurement,
        [Description("0002")]
        TypeMaterial,
        [Description("0003")]
        Category,
        [Description("0004")]
        EmplooyerType,
        [Description("0005")]
        SalaryType,
        [Description("0006")]
        ProcessType,

        [Description("0007")]
        FlowProcessType,

        [Description("0008")]
        CostCategory
    }
}
