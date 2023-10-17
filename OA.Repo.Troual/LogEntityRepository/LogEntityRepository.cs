using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.LogEntity;
using OA.Repo.Troual.Contracts.ILogEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.LogEntityRepository
{
    public class LogEntityRepository: ILogEntityRepository
    {
        private readonly TouralContext context;
        private DbSet<LogEntity> entities;
        public LogEntityRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<LogEntity>();
        }


        public void Delete(LogEntity entity)
        {
            throw new NotImplementedException();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 56;
            return (entities.OrderBy(z => z.ID).Last().ID) + 56;
        }
        public LogEntity Get(long id)
        {
            return entities.Where(z => z.ID == id).SingleOrDefault();
        }

        public List<LogEntity> GetALL()
        {
            return entities.ToList();
        }

        public LogEntity GetForActive(long id)
        {
            return entities.Where(z => z.ID == id).SingleOrDefault();
        }

        public List<LogEntity> GetQuery(Expression<Func<LogEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<LogEntity> GetQueryData(Expression<Func<LogEntity, bool>> predicate)
        {
            return entities.Where(predicate).OrderByDescending(z => z.CreatedDate).Include(z=>z.User).Skip(0).Take(20).ToList();
        }

        public int GetQuery(Expression<Func<LogEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(LogEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entities.Add(entity);
        }


        public void Remove(LogEntity entity)
        {
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(LogEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(LogEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<LogEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public LogEntity GetLastItem(Int64 UserID)
        {
            return null;
        }

        public List<LogEntity> GetQueryData(Expression<Func<LogEntity, bool>> predicate, int Page, int Row)
        {
            return entities.Where(predicate).OrderByDescending(z => z.CreatedDate).Include(z => z.User).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }
    }
}
