using Microsoft.EntityFrameworkCore;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.ProcessRepository
{
    public class ProcessBalanceStockRepository : IProcessBalanceStockRepository
    {
        private readonly TouralContext context;
        private DbSet<ProcessBalanceStockEntity> entities;
        public ProcessBalanceStockRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ProcessBalanceStockEntity>();
        }

        public void Delete(ProcessBalanceStockEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProcessBalanceStockEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).Include(z=>z.stockRoom_InitialBalanceEntity).SingleOrDefault();
        }

        public List<ProcessBalanceStockEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ProcessBalanceStockEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ProcessBalanceStockEntity> GetQuery(Expression<Func<ProcessBalanceStockEntity, bool>> predicate, int Page, int Row)
        {
            return entities.Where(predicate).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<ProcessBalanceStockEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ProcessBalanceStockEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(ProcessBalanceStockEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ProcessBalanceStockEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public void Update(ProcessBalanceEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateWithoutSave(ProcessEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public void UpdateWithoutSave(ProcessBalanceEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateWithoutSave(ProcessBalanceStockEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
