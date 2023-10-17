using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Common.EnumValues
{
    public enum SalaryTypeEnum
    {
        [Description("00050001")]
        PerHour,
        [Description("00050002")]
        PerMonth,
        
    }
}
