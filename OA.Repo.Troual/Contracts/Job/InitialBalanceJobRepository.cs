using OA.Data.Toural.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.Job
{
    public interface  IInitialBalanceJobRepository
    {
        List<InitialBalanceJobEntity> GetALL();
        InitialBalanceJobEntity Get(string id);
        List<InitialBalanceJobEntity> Get(string[] id);
        void Insert(InitialBalanceJobEntity entity);
        void Update(InitialBalanceJobEntity entity);
        void Delete(InitialBalanceJobEntity entity);
        void Remove(InitialBalanceJobEntity entity);
        List<InitialBalanceJobEntity> GetQuery(Expression<Func<InitialBalanceJobEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<InitialBalanceJobEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(InitialBalanceJobEntity entity);
    }
}
