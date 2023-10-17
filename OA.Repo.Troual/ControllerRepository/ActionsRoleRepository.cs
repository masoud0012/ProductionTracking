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
    public class ActionsRoleRepository: IActionsRoleRepository
    {
        private readonly TouralContext context;
        private DbSet<ActionsRoleEntity> entities;
        public ActionsRoleRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ActionsRoleEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public ActionsRoleEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<ActionsRoleEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ActionsRoleEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ActionsRoleEntity> GetQuery(Expression<Func<ActionsRoleEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<ActionsRoleEntity> GetQueryData(Expression<Func<ActionsRoleEntity, bool>> predicate)
        {
            return entities.Where(predicate).ToList();
        }

        public int GetQuery(Expression<Func<ActionsRoleEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ActionsRoleEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(ActionsRoleEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ActionsRoleEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ActionsRoleEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<ActionsRoleEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ActionsRoleEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
