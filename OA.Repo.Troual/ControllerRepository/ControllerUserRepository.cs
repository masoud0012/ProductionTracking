using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.ControllersEntity;
using OA.Repo.Troual.Contracts.IController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.ControllerRepository
{
    public class ControllerUserRepository: IControllerUserRepository
    {
        private readonly TouralContext context;
        private DbSet<ControllerUserEntity> entities;
        public ControllerUserRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ControllerUserEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public ControllerUserEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<ControllerUserEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ControllerUserEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ControllerUserEntity> GetQuery(Expression<Func<ControllerUserEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<ControllerUserEntity> GetQueryData(Expression<Func<ControllerUserEntity, bool>> predicate)
        {
            return entities.Where(predicate).Include(z=>z.ControllerEntity).ToList();
        }

        public int GetQuery(Expression<Func<ControllerUserEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ControllerUserEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(ControllerUserEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ControllerUserEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ControllerUserEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<ControllerUserEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ControllerUserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
