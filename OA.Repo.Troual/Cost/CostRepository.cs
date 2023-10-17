using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.Cost;
using OA.Repo.Troual.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Cost
{
    public class CostRepository : ICostRepository
    {
        private readonly TouralContext context;
        private DbSet<CostEntity> entities;
        public CostRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<CostEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public CostEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).Include(z => z.CostCategory).SingleOrDefault();
        }

        public List<CostEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).Include(z => z.CostCategory).ToList();
        }

        public CostEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<CostEntity> GetQuery(Expression<Func<CostEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).Include(z => z.CostCategory).ToList();
        }

        public List<CostEntity> GetQueryData(Expression<Func<CostEntity, bool>> predicate)
        {
            return entities.Where(predicate).Include(z => z.CostCategory).ToList();
        }

        public int GetQuery(Expression<Func<CostEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(CostEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(CostEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(CostEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = DateTime.Now;
            context.SaveChanges();
        }

        public void UpdateWithoutSave(CostEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = DateTime.Now;
        }

        public List<CostEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(CostEntity entity)
        {
            throw new NotImplementedException();
        }

        public CostEntity GetLastItem(Int64 UserID)
        {
            return entities.OrderByDescending(p => p.ModifiedDate).FirstOrDefault(z => z.CreatedById == UserID || z.ModifiedById == UserID);
        }

        public List<CostEntity> GetQueryData(DateTime startMiladiDate, DateTime endMiladiDate)
        {
            return entities.Where(z => z.CostDate.Value >= startMiladiDate && z.IsEnabled == true
                && z.RemainingMonth > 0
                && !(z.CalculationDate <= endMiladiDate && z.CalculationDate >= startMiladiDate)).ToList();
        }

        public List<CostEntity> GetCosts()
        {
            return entities.Where(z => 
                z.IsEnabled == true && 
                z.RemainingMonth > 0).ToList();
        }
    }
}
