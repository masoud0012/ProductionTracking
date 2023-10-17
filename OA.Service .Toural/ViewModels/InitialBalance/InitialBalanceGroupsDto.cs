using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.InitialBalance
{
    public class InitialBalanceGroupsDto
    {
        public Int64 CategoryTypeFK_ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public List<InitialBalancePoco> initialBalanceDtos { get; set; }
    }
}
