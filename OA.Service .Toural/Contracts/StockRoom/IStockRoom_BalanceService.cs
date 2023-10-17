using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.StockRoom;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.Contracts.StockRoom
{
    public interface IStockRoom_BalanceService
    {
        StockRoomVM Insert(StockRoom_InitialBalanceDto dto);
        StockRoomVM GetAll();

        StockRoomVM GetByID(Int64 ID);
        StockRoomVM Remove(Int64 ID);
        StockRoomVM Updae(StockRoom_InitialBalanceDto body);
        StockRoomVM Active(long id);
        StockRoomVM stockRoom_InitialBalanceEntitiesValidationForInsert(InitialBalancePoco body, long InitialBalanceID);

        StockRoomVM UpdateList(List<StockRoom_InitialBalanceDto> body);
        StockRoomVM Increase(StockRoom_InitialBalanceDto body);
    }
}
