using OA.Data.BaseEntities;
using OA.Data.Toural.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Cost
{
    public class CostEntity:BaseEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public Int64 CostCategoryID { get; set; }
        public CostCategoryEntity CostCategory { get; set; }
        public DateTime? CostDate { get; set; }
        public Int64 CostAmount { get; set; }
        public int Month { get; set; }
        public int RemainingMonth { get; set; }
        public DateTime CalculationDate { get; set; }
        public string Description { get; set; }
        public List<CostJobEntity> CostJobEntities { get; set; }


    }
}
