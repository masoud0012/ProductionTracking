using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.InitialBalance;
using OA.Repo.Troual.BaseRepository;
using OA.Repo.Troual.Contracts.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.InitialBalanceRepository
{
    public class InitialBalanceRepository : IInitialBalanceRepository
    {
        private readonly TouralContext context;
        private DbSet<InitialBalanceEntity> entities;
        public InitialBalanceRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<InitialBalanceEntity>();
        }


        public void Delete(InitialBalanceEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public InitialBalanceEntity Get(long id)
        {
            return entities.Include(z => z.UnitMeasurement)
                .Include(z => z.TypeMaterial)
                .Include(z=>z.CategoryType)
                .Include(z=>z.StockRoom_InitialBalanceEntity)
                .SingleOrDefault(z => z.Id == id && z.IsEnabled == true);
        }

        public List<InitialBalanceEntity> GetAll()
        {
            return entities.Include(z => z.TypeMaterial).Include(z => z.UnitMeasurement).AsEnumerable().ToList();
        }

        public InitialBalanceEntity getForRemove(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<InitialBalanceEntity> GetQuery(Expression<Func<InitialBalanceEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).Include(z=>z.UnitMeasurement).Include(z=>z.TypeMaterial).Include(z=>z.CategoryType).Include(z=>z.StockRoom_InitialBalanceEntity).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<InitialBalanceEntity> GetQueryGroupBy(Expression<Func<InitialBalanceEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate)
                .Include(z => z.UnitMeasurement).Include(z => z.TypeMaterial).Include(z => z.CategoryType).Include(z => z.StockRoom_InitialBalanceEntity)
                .OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }


        public int GetQuery(Expression<Func<InitialBalanceEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public List<InitialBalanceEntity> GetQueryData(Expression<Func<InitialBalanceEntity, bool>> predicate)
        {
            return entities.Where(predicate).Include(z=>z.CategoryType).Include(z=>z.StockRoom_InitialBalanceEntity).ToList();
        }

        public InitialBalanceEntity Insert(InitialBalanceEntity entity)
        {
            entity.IsEnabled = true;
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entities.Add(entity);
            return entity;
        }

        public void Remove(InitialBalanceEntity entity)
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

        public void Update(InitialBalanceEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = DateTime.Now;
            context.Update(entity);
            context.SaveChanges();
        }

        public List<InitialBalanceEntity> Get(long[] id)
        {
            return entities.Where(z => id.Contains(z.Id))
                .Include(z=>z.flowProcessEntity)
                    .ThenInclude(z=>z.flowProcessUserSalaryEntities)
                    .ThenInclude(z=>z.User)
                .Include(z=>z.UnitMeasurement)
                .Include(z=>z.CategoryType)
                .Include(z=>z.TypeMaterial).ToList();
        }

        public InitialBalanceEntity GetLastItem(Int64 UserID)
        {
            var maxDate = entities.OrderByDescending(z => z.ModifiedDate ).FirstOrDefault(z => z.CreatedById == UserID || z.ModifiedById == UserID);
            return maxDate;
        }

        public InitialBalanceEntity GetWastage(long id)
        {
            return entities.Where(z => z.Id == id).Include(z => z.wastageEntities).ThenInclude(z=>z.FlowProcessEntity).Include(z=>z.CategoryType).Include(z=>z.UnitMeasurement).FirstOrDefault();
        }
    }
}
