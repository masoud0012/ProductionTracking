using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IProcess
{
    public  interface IProcessBalanceStockRepository
    {

        List<ProcessBalanceStockEntity> GetALL();
        ProcessBalanceStockEntity Get(long id);
        ProcessBalanceStockEntity GetForActive(long id);
        void Insert(ProcessBalanceStockEntity entity);
        void Update(ProcessBalanceStockEntity entity);
        void Delete(ProcessBalanceStockEntity entity);
        void Remove(ProcessBalanceStockEntity entity);
        List<ProcessBalanceStockEntity> GetQuery(Expression<Func<ProcessBalanceStockEntity, bool>> predicate, int Page, int Row);
        int GetQuery(Expression<Func<ProcessBalanceStockEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ProcessBalanceStockEntity entity);
    }
}
