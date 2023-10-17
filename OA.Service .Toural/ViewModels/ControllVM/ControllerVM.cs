using System;
using System.Collections.Generic;

namespace OA.Service_.Toural.ViewModels.ControllVM
{
    public class ControllerVM : BaseVM
    {
        public ControllerDto ControllerDto { get; set; }
        public List<ControllerDto> ControllerDtos { get; set; }
        public ActionDto ActionDto { get; set; }
        public List<ActionDto> ActionDtos { get; set; }
        public Int64 numberRows { get; set; }

    }
}
