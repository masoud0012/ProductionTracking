using OA.Data.Toural.StockRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repo.Troual.Contracts.StockRoom
{
    public interface IStockRoom_InitialBalanceRepository
    {
        List<StockRoom_InitialBalanceEntity> GetALL();
        StockRoom_InitialBalanceEntity Get(long id);
        List<StockRoom_InitialBalanceEntity> Get(long[] id);
        bool ChecIsValidAssign(long stockID, Int64 balanceID,long count, long availableCount);
        long CalcAssignedBeforeForUpdate(Int64 balanceID, Int64 StockID);
        bool ChecIsAssigned(long stockID, Int64 balanceID);
        void Insert(StockRoom_InitialBalanceEntity entity);
        void Insert(List<StockRoom_InitialBalanceEntity> entity);
        void Update(StockRoom_InitialBalanceEntity entity);
        StockRoom_InitialBalanceEntity FindAllByID(long id);
        void Delete(StockRoom_InitialBalanceEntity entity);
        void Remove(StockRoom_InitialBalanceEntity entity);
        void SaveChanges();
        long CalcAssignedBefore(Int64 balanceID);
        StockRoom_InitialBalanceEntity GetForActive(long id);
        StockRoom_InitialBalanceEntity GetByBalanceIDStockID(long stockID, Int64 balanceID);



    }
}
