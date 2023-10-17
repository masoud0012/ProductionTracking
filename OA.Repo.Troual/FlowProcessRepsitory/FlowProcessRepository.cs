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
    public class FlowProcessRepository: IFlowProcessRepository
    {
        private readonly TouralContext context;
        private DbSet<FlowProcessEntity> entities;
        public FlowProcessRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<FlowProcessEntity>();
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
        public FlowProcessEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true)
                .Include(z=>z.processEntity)
                .ThenInclude(z=>z.processBalanceEntities)
                .ThenInclude(z=>z.initialBalanceEntity)
                .Include(z=>z.wastageEntities)
                .ThenInclude(z => z.InitialBalanceEntity)
                 .ThenInclude(z => z.UnitMeasurement)
                .Include(z=>z.InitialBalanceEntity)
                 .ThenInclude(z => z.UnitMeasurement)
                .Include(z=>z.flowProcessUserSalaryEntities)
                .ThenInclude(z=>z.User)
                .ThenInclude(z=>z.SalaryType)
                .Include(z=>z.flowPorcessStockInitialEntities)
                .ThenInclude(z=>z.stockRoom_InitialBalanceEntity)
                .ThenInclude(z=>z.InitialBalanceEntities)
                .ThenInclude(z=>z.StockRoom_InitialBalanceEntity)
                .ThenInclude(z=>z.StockRoomEntities)
                .Include(z=>z.InitialBalanceEntity)
                    .ThenInclude(z=>z.StockRoom_InitialBalanceEntity)
                .SingleOrDefault();
        }

        public List<FlowProcessEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public FlowProcessEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<FlowProcessEntity> GetQuery(Expression<Func<FlowProcessEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<FlowProcessEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(FlowProcessEntity entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entity.IsEnabled = true;
            entity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.FlowProcess) + LastInsertedID();
            entities.Add(entity);
        }


        public void Remove(FlowProcessEntity entity)
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

        public List<FlowProcessEntity> Get(long[] id)
        {
            return entities.Where(z => id.Contains(z.Id))
                    .Include(z=>z.flowProcessUserSalaryEntities)
                    .Include(z=>z.wastageEntities)
                    .Include(z=>z.InitialBalanceEntity)
                    .Include(z=>z.processEntity)
                    .ThenInclude(z=>z.processBalanceEntities)
                    .ThenInclude(z=>z.stockRoom_InitialBalanceEntity)
                    .Include(z=>z.flowPorcessStockInitialEntities)
                .ToList();
        }

        public FlowProcessEntity GetLastItem(Int64 UserID)
        {
            return entities.OrderByDescending(p => p.ModifiedDate).FirstOrDefault(z => z.CreatedById == UserID || z.ModifiedById == UserID);
        }
    }
}
