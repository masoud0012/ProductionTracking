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
    public  class FlowProcessUserSalaryRepository: IFlowProcessUserSalaryRepository
    {
        private readonly TouralContext context;
        private DbSet<FlowProcessUserSalaryEntity> entities;
        public FlowProcessUserSalaryRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<FlowProcessUserSalaryEntity>();
        }

        
        public void Delete(FlowProcessUserSalaryEntity entity)
        {
            throw new NotImplementedException();
        }

        public long LastInsertedID()
        {
            return (entities.OrderByDescending(z => z.Id).Last().Id) + 100;
        }
        public FlowProcessUserSalaryEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<FlowProcessUserSalaryEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public FlowProcessUserSalaryEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<FlowProcessUserSalaryEntity> GetQuery(Expression<Func<FlowProcessUserSalaryEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<FlowProcessUserSalaryEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(FlowProcessUserSalaryEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.IsEnabled = true;
            entities.Add(entity);
        }


        public void Remove(FlowProcessUserSalaryEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(FlowProcessUserSalaryEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(FlowProcessUserSalaryEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

    }
}
