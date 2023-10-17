using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Job
{
    public class CostJobEntity
    {
        public string ID { get; set; }
        public Int64 CostEntityID { get; set; }
        public Cost.CostEntity CostEntity { get; set; }
        public int MonthDuration { get; set; }
        public string JobEntityID { get; set; }

        public JobEntities JobEntitiy { get; set; }
    }
}
