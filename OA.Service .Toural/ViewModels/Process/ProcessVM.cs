using OA.Service_.Toural.ViewModels.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Process
{
    public class ProcessVM: BaseVM
    {
        public ProcessDto processDto { get; set; }
        public List<ProcessDto> processDtos { get; set; }
        public ProcessBalanceDto processBalanceDto { get; set; }
        public List<ProcessBalanceDto> processBalanceDtos { get; set; }
        public List<InitialBalancePoco> initialBalanceDtos { get; set; }
        public ProcessDefinitionDto ProcessDefinitionDto { get; set; }
        public List<ProcessDefinitionDto> processDefinitionDtos { get; set; }
        public ProcessUserDto processUserDto { get; set; }
        public List<ProcessUserDto> processUserDtos { get; set; }
        public int numberRows { get; set; }
    }
}
