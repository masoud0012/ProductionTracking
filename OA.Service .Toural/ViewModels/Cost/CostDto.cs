using OA.Service_.Toural.ViewModels.DashboardVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Cost
{
    public class CostDto:BasePoco
    {
        public int Page { get; set; }
        public int Row { get; set; }
        public long[] ids { get; set; }
        public string Sort { get; set; }
        public Int64 CostAmount { get; set; }
        public int RemainingMonth { get; set; }
        public string CostDate { get; set; }
        public string CostDateMiladi { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DashboardDto DashboardDto { get; set; }
        public CostCategoryDto costCategoryDto { get; set; }
    }

    public class ExcelDto
    {
        public byte[] Content { get; set; }
        public string contentType { get; set; }
        public string fileName { get; set; }
    }
}
