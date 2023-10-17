using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels
{
    public class PersmissionActionsDto
    {
        public string ControllerName { get; set; }
        public string Acttion { get; set; }
    }

    public class PersmissionActionsVM
    {
        public List<PersmissionActionsDto> PersmissionActionsDtos { get; set; } 
    }
}
