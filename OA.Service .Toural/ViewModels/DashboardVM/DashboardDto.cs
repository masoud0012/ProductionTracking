using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.DashboardVM
{
    public class DashboardDto
    {
        public string FullName { get; set; }
        public string TimeActivity { get; set; }
        public string DateActivity { get; set; }
        public string ActivityName { get; set; }
        public bool isCreated { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
        public int OpenProcessCount { get; set; }
        public List<Cost.CostCategoryDto> CostCategoryDtos { get; set; }
    }

}
