using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.FlowProcess
{
    public class FlowProcessVM:BaseVM
    {
        public FlowProcessDto flowProcessDto { get; set; }
        public List<FlowProcessDto> flowProcessDtos { get; set; }
        public int numberRows { get; set; }
    }
}
