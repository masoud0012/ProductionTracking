using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Cost
{
    public class CostVM:BaseVM
    {
        public CostDto costDto { get; set; }
        public List<CostDto> costDtos { get; set; }

        public CostCategoryDto costCategoryDto { get; set; }
        public List<CostCategoryDto> costCategoryDtos { get; set; }
        public int numberRows { get; set; }
    }
}
