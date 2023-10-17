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
    public class ControllerRoleRepository: IControllerRoleRepository
    {
        private readonly TouralContext context;
        private DbSet<ControllerRoleEntity> entities;
        public ControllerRoleRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ControllerRoleEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public ControllerRoleEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<ControllerRoleEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ControllerRoleEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ControllerRoleEntity> GetQuery(Expression<Func<ControllerRoleEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<ControllerRoleEntity> GetQueryData(Expression<Func<ControllerRoleEntity, bool>> predicate)
        {
            return entities.Where(predicate).ToList();
        }

        public int GetQuery(Expression<Func<ControllerRoleEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ControllerRoleEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(ControllerRoleEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ControllerRoleEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ControllerRoleEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<ControllerRoleEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ControllerRoleEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
