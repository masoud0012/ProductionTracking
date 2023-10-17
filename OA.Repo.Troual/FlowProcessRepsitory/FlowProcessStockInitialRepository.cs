using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.FlowProcess;
using OA.Repo.Troual.Contracts.IFlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.FlowProcessRepsitory
{
    public  class FlowProcessStockInitialRepository: IFlowProcessStockInitialRepository
    {
        private readonly TouralContext context;
        private DbSet<FlowProcessStockInitialEntity> entities;
        public FlowProcessStockInitialRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<FlowProcessStockInitialEntity>();
        }

        public void Delete(FlowProcessEntity entity)
        {
            throw new NotImplementedException();
        }

        public long LastInsertedID()
        {

            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 99;
            return (entities.OrderBy(z => z.Id).Last().Id) + 100;
        }
        public FlowProcessStockInitialEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true)
                .SingleOrDefault();
        }

        public List<FlowProcessStockInitialEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public FlowProcessStockInitialEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<FlowProcessStockInitialEntity> GetQuery(Expression<Func<FlowProcessStockInitialEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<FlowProcessStockInitialEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(FlowProcessStockInitialEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(FlowProcessStockInitialEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(FlowProcessEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(FlowProcessEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public List<FlowProcessStockInitialEntity> Get(long[] id)
        {
            return entities.Where(z => id.Contains(z.Id))
                .ToList();
        }

        public void Update(FlowProcessStockInitialEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FlowProcessStockInitialEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateWithoutSave(FlowProcessStockInitialEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
