using OA.Service_.Toural.ViewModels.DashboardVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Cost
{
    public class CostCategoryDto : BasePoco
    {
        public string Sort { get; set; }
        public int Page { get; set; }
        public int Row { get; set; }
        public long[] ids { get; set; }
        public string TotalPrice { get; set; }
        public int CostCount { get; set; }
        public DashboardDto DashboardDto { get; set; }
    }
}
