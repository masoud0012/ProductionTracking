using OA.Data.Toural.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.Contracts.StockRoom
{
    public interface IStockRoomRepository
    {
        List<StockRoomEntity> GetALL();
        StockRoomEntity Get(long id);
        StockRoomEntity GetForActive(long id);
        void Insert(StockRoomEntity entity);
        void Update(StockRoomEntity entity);
        void Delete(StockRoomEntity entity);
        void Remove(StockRoomEntity entity);
        long LastInsertedID();
        List<StockRoomEntity> GetQuery(Expression<Func<StockRoomEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<StockRoomEntity, bool>> predicate);
        void SaveChanges();
        StockRoomEntity GetLastItem(Int64 UserID);
        void UpdateWithoutSave(StockRoomEntity entity);
    }
}
