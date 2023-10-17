using OA.Data.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public  class ProcessDefinitionEntity : BaseEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ProcessEntity> ProcessEntities { get; set; }
    }
}
