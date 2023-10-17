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
    public class InitialBalanceJobRepository: IInitialBalanceJobRepository
    {
        private readonly TouralContext context;
        private DbSet<InitialBalanceJobEntity> entities;
        public InitialBalanceJobRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<InitialBalanceJobEntity>();
        }

        public void Delete(InitialBalanceJobEntity entity)
        {
            throw new NotImplementedException();
        }
        public InitialBalanceJobEntity Get(string id)
        {
            return entities.Where(z => z.ID == id)
                .SingleOrDefault();
        }

        public List<InitialBalanceJobEntity> GetALL()
        {
            return entities.ToList();
        }


        public List<InitialBalanceJobEntity> GetQuery(Expression<Func<InitialBalanceJobEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<InitialBalanceJobEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(InitialBalanceJobEntity entity)
        {
            entities.Add(entity);
        }


        public void Remove(InitialBalanceJobEntity entity)
        {
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(InitialBalanceJobEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(InitialBalanceJobEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<InitialBalanceJobEntity> Get(string[] id)
        {
            return entities.Where(z => id.Contains(z.ID))
                .ToList();
        }
    }
}
