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
    public class ControllerRepository:IControllerRepository
    {
        private readonly TouralContext context;
        private DbSet<ControllerEntity> entities;
        public ControllerRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ControllerEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public ControllerEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).Include(z=>z.ActionsEntities).Include(z=>z.ControllerRoleEntities).SingleOrDefault();
        }

        public List<ControllerEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ControllerEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ControllerEntity> GetQuery(Expression<Func<ControllerEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).Include(z=>z.ActionsEntities).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<ControllerEntity> GetQueryData(Expression<Func<ControllerEntity, bool>> predicate)
        {
            return entities.Where(predicate).ToList();
        }

        public int GetQuery(Expression<Func<ControllerEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ControllerEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(ControllerEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ControllerEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ControllerEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<ControllerEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ControllerEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
