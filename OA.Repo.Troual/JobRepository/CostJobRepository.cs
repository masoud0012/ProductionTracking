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
    public class CostJobRepository: ICostJobRepository
    {
        private readonly TouralContext context;
        private DbSet<CostJobEntity> entities;
        public CostJobRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<CostJobEntity>();
        }

        public void Delete(CostJobEntity entity)
        {
            throw new NotImplementedException();
        }
        public CostJobEntity Get(string id)
        {
            return entities.Where(z => z.ID == id)
                .SingleOrDefault();
        }

        public List<CostJobEntity> GetALL()
        {
            return entities.ToList();
        }


        public List<CostJobEntity> GetQuery(Expression<Func<CostJobEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<CostJobEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(CostJobEntity entity)
        {
            entities.Add(entity);
        }


        public void Remove(CostJobEntity entity)
        {
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(CostJobEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(CostJobEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<CostJobEntity> Get(string[] id)
        {
            return entities.Where(z => id.Contains(z.ID))
                .ToList();
        }
    }
}
