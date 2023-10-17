using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IProcess
{
    public interface IProcessBalanceRepository
    {
        List<ProcessBalanceEntity> GetALL();
        ProcessBalanceEntity Get(long id);
        ProcessBalanceEntity GetForActive(long id);
        List<ProcessBalanceEntity> GetProcessBalances(long id);
        void Insert(ProcessBalanceEntity entity);
        void Update(ProcessBalanceEntity entity);
        void Delete(ProcessBalanceEntity entity);
        void Remove(ProcessBalanceEntity entity);
        List<ProcessBalanceEntity> GetQuery(Expression<Func<ProcessBalanceEntity, bool>> predicate, int Page, int Row);
        int GetQuery(Expression<Func<ProcessBalanceEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ProcessBalanceEntity entity);
    }
}
