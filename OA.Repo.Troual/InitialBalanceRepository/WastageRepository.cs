using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.InitialBalance;
using OA.Repo.Troual.Contracts.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.InitialBalanceRepository
{
    public class WastageRepository: IWastageRepository
    {
        private readonly TouralContext context;
        private DbSet<WastageEntity> entities;
        public WastageRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<WastageEntity>();
        }


        public void Delete(WastageEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public WastageEntity Get(long id)
        {
            return entities
                .SingleOrDefault(z => z.Id == id && z.IsEnabled == true);
        }

        public List<WastageEntity> GetAll()
        {
            return entities.Where(z=>z.IsEnabled==true).Include(z=>z.FlowProcessEntity).Include(z=>z.InitialBalanceEntity).AsEnumerable().ToList();
        }

        public List<WastageEntity> GetAllValue()
        {
            return entities.Where(z => z.IsEnabled == true&&z.Count>0).Include(z => z.InitialBalanceEntity).ThenInclude(z=>z.UnitMeasurement).AsEnumerable().ToList();
        }

        public WastageEntity getForRemove(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<WastageEntity> GetQuery(Expression<Func<WastageEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Include(z=>z.FlowProcessEntity).Include(z=>z.InitialBalanceEntity).ThenInclude(z=>z.UnitMeasurement).Take(Row).ToList();
        }

        public List<WastageEntity> GetQueryGroupBy(Expression<Func<WastageEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate)
                .OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }


        public int GetQuery(Expression<Func<WastageEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public WastageEntity Insert(WastageEntity entity)
        {
            entity.IsEnabled = true;
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entities.Add(entity);
            return entity;
        }

        public void Remove(WastageEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 34;
            return (entities.OrderBy(z => z.Id).Last().Id) + 35;
        }

        public void Update(WastageEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Update(entity);
            context.SaveChanges();
        }

        public List<WastageEntity> Get(long[] id)
        {
            return entities.Where(z => id.Contains(z.Id)).ToList();
        }
    }
}
