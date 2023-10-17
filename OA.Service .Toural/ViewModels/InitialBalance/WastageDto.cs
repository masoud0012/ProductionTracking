using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.InitialBalance
{
    public class WastageDto:BasePoco
    {
        public long WastageCount { get; set; }
        public long UsedCount { get; set; }
        public string FlowTitle { get; set; }
        public string UnitName { get; set; }
        public Int64 PricePerUnit { get; set; }

    }
}
