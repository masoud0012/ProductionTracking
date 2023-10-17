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
    public  class ActionsUserRepository: IActionsUserRepository
    {
        private readonly TouralContext context;
        private DbSet<ActionsUserEntity> entities;
        public ActionsUserRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ActionsUserEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public ActionsUserEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<ActionsUserEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ActionsUserEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ActionsUserEntity> GetQuery(Expression<Func<ActionsUserEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<ActionsUserEntity> GetQueryData(Expression<Func<ActionsUserEntity, bool>> predicate)
        {
            return entities.Where(predicate).Include(z=>z.ActionsEntity).ThenInclude(z=>z.ControllerEntity).ToList();
        }

        public int GetQuery(Expression<Func<ActionsUserEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ActionsUserEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(ActionsUserEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ActionsUserEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ActionsUserEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<ActionsUserEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ActionsUserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
