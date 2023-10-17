using OA.Data.Toural.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.Job
{
    public interface ICostJobRepository
    {
        List<CostJobEntity> GetALL();
        CostJobEntity Get(string id);
        List<CostJobEntity> Get(string[] id);
        void Insert(CostJobEntity entity);
        void Update(CostJobEntity entity);
        void Delete(CostJobEntity entity);
        void Remove(CostJobEntity entity);
        List<CostJobEntity> GetQuery(Expression<Func<CostJobEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<CostJobEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(CostJobEntity entity);
    }
}
