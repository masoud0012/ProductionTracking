using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.ControllVM
{
    public  class ControllerDto:BasePoco
    {
        public String TitleEn { get; set; }
        public String TitleFr { get; set; }
        public ActionDto ActionDto { get; set; }
        public List<ActionDto> ActionDtos { get; set; }
    }
}
