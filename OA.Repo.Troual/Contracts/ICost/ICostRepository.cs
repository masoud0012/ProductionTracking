using OA.Data.Toural.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts
{
    public interface ICostRepository
    {
        CostEntity GetLastItem(Int64 UserID);
        List<CostEntity> GetALL();
        CostEntity Get(long id);
        List<CostEntity> Get(long[] id);
        CostEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(CostEntity entity);
        void Update(CostEntity entity);
        void Delete(CostEntity entity);
        void Remove(CostEntity entity);
        List<CostEntity> GetQuery(Expression<Func<CostEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<CostEntity> GetQueryData(Expression<Func<CostEntity, bool>> predicate);
        List<CostEntity> GetQueryData(DateTime startMiladiDate,DateTime endMiladiDate);
        int GetQuery(Expression<Func<CostEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(CostEntity entity);
        List<CostEntity> GetCosts();
    }
}
