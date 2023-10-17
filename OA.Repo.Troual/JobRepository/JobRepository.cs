using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.Job;
using OA.Repo.Troual.Contracts.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.JobRepository
{
    public class JobRepository: IJobRepository
    {
        private readonly TouralContext context;
        private DbSet<JobEntities> entities;
        public JobRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<JobEntities>();
        }

        public void Delete(JobEntities entity)
        {
            throw new NotImplementedException();
        }
        public JobEntities Get(string id)
        {
            return entities.Where(z => z.JobEntityID==id)
                .Include(z=>z.CostJobEntities)
                .ThenInclude(z=>z.CostEntity)
                .Include(z=>z.InitialBalanceJobEntities)
                .ThenInclude(z=>z.InitialBalanceEntity)
                .SingleOrDefault();
        }

        public List<JobEntities> GetALL()
        {
            return entities.ToList();
        }


        public List<JobEntities> GetQuery(Expression<Func<JobEntities, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<JobEntities> GetQueryData(Expression<Func<JobEntities, bool>> predicate)
        {
            return entities.Where(predicate).ToList();
        }

        public List<JobEntities> GetQueryDataWithDependency(Expression<Func<JobEntities, bool>> predicate)
        {
            return entities.Where(predicate)
                .Include(z=>z.CostJobEntities)
                .Include(z=>z.InitialBalanceJobEntities)
                .ThenInclude(z=>z.InitialBalanceEntity)
                .ToList();
        }

        public int GetQuery(Expression<Func<JobEntities, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(JobEntities entity)
        {
            entity.JobEntityID = Guid.NewGuid().ToString();
            entities.Add(entity);
        }


        public void Remove(JobEntities entity)
        {
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(JobEntities entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(JobEntities entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<JobEntities> Get(string[] id)
        {
            return entities.Where(z => id.Contains(z.JobEntityID))
                .ToList();
        }

    }
}
