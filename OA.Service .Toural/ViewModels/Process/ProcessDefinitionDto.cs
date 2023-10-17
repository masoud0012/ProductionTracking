using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Process
{
    public class ProcessDefinitionDto:BasePoco
    {
        public int Page { get; set; }
        public int Row { get; set; }
        public string Sort { get; set; }

        public long[] ids { get; set; }
    }
}
