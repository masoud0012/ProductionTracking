using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.Contracts
{
    public interface IStockRoomService
    {
        StockRoomVM Insert(StockRoomDto Entity);
        StockRoomVM Edit(StockRoomDto Entity);
        StockRoomVM GetAll();
        StockRoomVM GetByID(long Id);
        StockRoomVM Remove(long[] id);
        StockRoomVM GetByDto(StockRoomDto body);

        StockRoomVM Assign(StockRoom_InitialBalanceDto dto);
        StockRoomVM Remove(long id);
        StockRoomVM Active(long id);
        StockRoomVM Search(StockRoomDto body);
        StockRoomVM GetByIDs(long[] ID);
    }
}
