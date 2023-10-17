using OA.Common.Constants;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.InitialBalance
{
    public class InitialBalanceVM:BaseVM
    {
        public int numberRows { get; set; }
        public InitialBalanceVM()
        {
            base.Code = ConstantsValue.successCode;
            base.ErrorMessage = ConstantsValue.successMessage;
        }
        public GeneralParamterPoco generalParamterDto { get; set; }
        public List<GeneralParamterPoco> generalParamterDtos { get; set; }
        public List<WastageDto> WastageDtos { get; set; }
        public InitialBalancePoco initialBalanceDto { get; set; }
        public List<InitialBalancePoco> initialBalanceDtos { get; set; }
        public List<InitialBalanceGroupsDto> initialBalanceGroupsDtos { get; set; }
        public List<StockRoom_InitialBalanceDto> StockRoom_InitialBalanceDtos { get; set; }
    }
}
