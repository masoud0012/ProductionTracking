using OA.Data.Toural.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.ICost
{
    public interface ICostCategoryRepository
    {
        List<CostCategoryEntity> GetALL();
        CostCategoryEntity Get(long id);
        List<CostCategoryEntity> Get(long[] id);
        CostCategoryEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(CostCategoryEntity entity);
        void Update(CostCategoryEntity entity);
        void Delete(CostCategoryEntity entity);
        void Remove(CostCategoryEntity entity);
        List<CostCategoryEntity> GetQuery(Expression<Func<CostCategoryEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<CostCategoryEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(CostCategoryEntity entity);
        CostCategoryEntity GetLastItem(Int64 UserID);
        List<CostCategoryEntity> GetQueryData(Expression<Func<CostCategoryEntity, bool>> predicate);
    }
}
