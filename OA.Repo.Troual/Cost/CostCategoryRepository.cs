using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.Cost;
using OA.Repo.Troual.Contracts.ICost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Cost
{
    public  class CostCategoryRepository: ICostCategoryRepository
    {
        private readonly TouralContext context;
        private DbSet<CostCategoryEntity> entities;
        public CostCategoryRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<CostCategoryEntity>();
        }


        public void Delete(CostCategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 56;
            return (entities.OrderBy(z => z.Id).Last().Id) + 56;
        }
        public CostCategoryEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<CostCategoryEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public CostCategoryEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<CostCategoryEntity> GetQuery(Expression<Func<CostCategoryEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<CostCategoryEntity> GetQueryData(Expression<Func<CostCategoryEntity, bool>> predicate)
        {
            return entities.Where(predicate).Include(z=>z.costEntities).ToList();
        }

        public int GetQuery(Expression<Func<CostCategoryEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(CostCategoryEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(CostCategoryEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(CostCategoryEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = DateTime.Now;
            context.SaveChanges();
        }

        public void UpdateWithoutSave(CostCategoryEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<CostCategoryEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public CostCategoryEntity GetLastItem(Int64 UserID)
        {
            return entities.OrderByDescending(p => p.ModifiedDate).FirstOrDefault(z => z.CreatedById == UserID || z.ModifiedById == UserID);
        }
    }
}
