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
    public class ActionRepository: IActionRepository
    {
        private readonly TouralContext context;
        private DbSet<ActionsEntity> entities;
        public ActionRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ActionsEntity>();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 28;
            return (entities.OrderBy(z => z.Id).Last().Id) + 28;
        }
        public ActionsEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<ActionsEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true&&z.ControllerEntity.IsEnabled==true).Include(z=>z.ControllerEntity).ToList();
        }

        public ActionsEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ActionsEntity> GetQuery(Expression<Func<ActionsEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public List<ActionsEntity> GetQueryData(Expression<Func<ActionsEntity, bool>> predicate)
        {
            return entities.Where(predicate).ToList();
        }

        public int GetQuery(Expression<Func<ActionsEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ActionsEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(ActionsEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ActionsEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ActionsEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<ActionsEntity> Get(long[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ActionsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
