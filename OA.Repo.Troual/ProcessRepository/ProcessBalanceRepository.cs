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
    public class ProcessBalanceRepository: IProcessBalanceRepository
    {
        private readonly TouralContext context;
        private DbSet<ProcessBalanceEntity> entities;
        public ProcessBalanceRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ProcessBalanceEntity>();
        }

        public void Delete(ProcessBalanceEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProcessBalanceEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true)
                .Include(z=>z.processBalanceStockEntities)
                .ThenInclude(z=>z.stockRoom_InitialBalanceEntity).SingleOrDefault();
        }

        public List<ProcessBalanceEntity> GetProcessBalances(long id)
        {
            return entities.Where(z => z.processEntityID == id && z.IsEnabled == true)
                .Include(z => z.processBalanceStockEntities)
                .ThenInclude(z => z.stockRoom_InitialBalanceEntity).ToList();
        }

        public List<ProcessBalanceEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ProcessBalanceEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ProcessBalanceEntity> GetQuery(Expression<Func<ProcessBalanceEntity, bool>> predicate, int Page, int Row)
        {
            return entities.Where(predicate).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<ProcessBalanceEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ProcessBalanceEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(ProcessBalanceEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ProcessEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            if (entities.Any(z => z.Id != entity.Id))
                throw new CustomErrorException(ConstantsValue.DuplicateNameCode, ConstantsValue.DuplicateNameMsg);
            context.SaveChanges();
        }

        public void Update(ProcessBalanceEntity entity)
        {
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
    }
}
