using OA.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.StockRoom
{
    public class StockRoomVM:BaseVM
    {
        public StockRoomVM()
        {
            base.Code = ConstantsValue.successCode;
            base.ErrorMessage = ConstantsValue.successMessage;
        }
        public long numberRows { get; set; }
        public StockRoomDto stockRoomDto { get; set; }
        public List<StockRoomDto> stockRoomDtos { get; set; }

        public StockRoom_InitialBalanceDto stockRoomBalanceDto { get; set; }
        public List<StockRoom_InitialBalanceDto> stockRoomBalanceDtos { get; set; }
    }
}
