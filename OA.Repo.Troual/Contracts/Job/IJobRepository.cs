using OA.Data.Toural.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.Job
{
    public  interface IJobRepository
    {
        List<JobEntities> GetALL();
        JobEntities Get(string id);
        List<JobEntities> Get(string[] id);
        void Insert(JobEntities entity);
        void Update(JobEntities entity);
        void Delete(JobEntities entity);
        void Remove(JobEntities entity);
        List<JobEntities> GetQuery(Expression<Func<JobEntities, bool>> predicate, int Page, int Row, string orderBy);
        List<JobEntities> GetQueryDataWithDependency(Expression<Func<JobEntities, bool>> predicate);
        int GetQuery(Expression<Func<JobEntities, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(JobEntities entity);
        List<JobEntities> GetQueryData(Expression<Func<JobEntities, bool>> predicate);
    }
}
