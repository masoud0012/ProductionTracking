using OA.Data.Toural.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.Contracts.InitialBalance
{
    public interface IInitialBalanceRepository
    {
        InitialBalanceEntity GetWastage(long id);
        List<InitialBalanceEntity> GetAll();
        InitialBalanceEntity Get(long id);
        List<InitialBalanceEntity> Get(long[] id);
        InitialBalanceEntity Insert(InitialBalanceEntity entity);
        void Update(InitialBalanceEntity entity);
        void Delete(InitialBalanceEntity entity);
        void Remove(InitialBalanceEntity entity);
        void SaveChanges();
        long LastInsertedID();
        InitialBalanceEntity getForRemove(long id);
        List<InitialBalanceEntity> GetQuery(Expression<Func<InitialBalanceEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<InitialBalanceEntity> GetQueryGroupBy(Expression<Func<InitialBalanceEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<InitialBalanceEntity, bool>> predicate);
        List<InitialBalanceEntity> GetQueryData(Expression<Func<InitialBalanceEntity, bool>> predicate);
        InitialBalanceEntity GetLastItem(Int64 UserID);
    }
}
