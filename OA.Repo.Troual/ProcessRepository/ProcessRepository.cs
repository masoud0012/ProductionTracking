using Microsoft.EntityFrameworkCore;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.ProcessRepository
{
    public class ProcessRepository : IProcessRepository
    {
        private readonly TouralContext context;
        private DbSet<ProcessEntity> entities;
        public ProcessRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ProcessEntity>();
        }

        public void Delete(ProcessEntity entity)
        {
            entities.Remove(entity);
        }

        public ProcessEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true)
                .Include(z=>z.flowProcessEntities)
                .Include(z=>z.UserContractors)
                .Include(z => z.processBalanceEntities.Where(z=>z.IsEnabled==true))
                .ThenInclude(z=>z.stockRoom_InitialBalanceEntity)
                .Include(z=>z.processBalanceEntities.Where(z => z.IsEnabled == true))
                .ThenInclude(z=>z.initialBalanceEntity)
                .SingleOrDefault();
        }

        public List<ProcessEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true&&z.flowProcessEntities.Count==0).Include(z=>z.flowProcessEntities).ToList();
        }

        public ProcessEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<ProcessEntity> GetQuery(Expression<Func<ProcessEntity, bool>> predicate, int Page, int Row, string orderBy,int status)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            if (status == 0)
            {
                var query = entities.Where(predicate)
                        .Include(z => z.processDefinitionEntity)
                        .Include(z => z.ContractorType)
                        .Include(z => z.UserContractors)
                        .Include(z => z.flowProcessEntities)
                    .OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row);
                return query.ToList();
            }
            else if(status==1)
            {
                var query = entities.Where(predicate).Where(z => z.flowProcessEntities.Count==0)
                        .Include(z => z.processDefinitionEntity)
                        .Include(z => z.ContractorType)
                        .Include(z => z.UserContractors)
                        .Include(z => z.flowProcessEntities)
                    .OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row);
                return query.ToList();
            }
            else
            {
                var query = entities.Where(predicate)
                                    .Where(z=>z.flowProcessEntities.Count>0)
                        .Include(z => z.processDefinitionEntity)
                        .Include(z => z.ContractorType)
                        .Include(z => z.UserContractors)
                        .Include(z => z.flowProcessEntities)
                    .OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row);
                return query.ToList();
            }

        }

        public int GetQuery(Expression<Func<ProcessEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(ProcessEntity entity)
        {
            entity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.Process) + LastInsertedID();
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(ProcessEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ProcessEntity entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            if (entities.Any(z => z.Id != entity.Id && z.Title == entity.Title && z.IsEnabled == true))
                throw new CustomErrorException(ConstantsValue.DuplicateNameCode, ConstantsValue.DuplicateNameMsg);
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ProcessEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public long LastInsertedID()
        {
            if (entities.Count() == 0)
                return 89;
            return (entities.OrderBy(z => z.Id).Last().Id) + 89;
        }


        public ProcessEntity GetLastItem(Int64 UserID)
        {
            return entities.OrderByDescending(p => p.ModifiedDate).FirstOrDefault(z => z.CreatedById == UserID || z.ModifiedById == UserID);
        }
    }
}
