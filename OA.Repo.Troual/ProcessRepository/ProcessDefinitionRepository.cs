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
    public class ProcessDefinitionRepository : IProcessDefinitionRepository
    {
        private readonly TouralContext context;
        private DbSet<ProcessDefinitionEntity> entities;
        public ProcessDefinitionRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ProcessDefinitionEntity>();
        }

        public void Delete(ProcessDefinitionEntity entity)
        {
            entities.Remove(entity);
            SaveChanges();
        }

        public List<ProcessDefinitionEntity> GetQuery(Expression<Func<ProcessDefinitionEntity, bool>> predicate, int Page, int Row,string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<ProcessDefinitionEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public ProcessDefinitionEntity Get(long id)
        {
            var entity = entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
            if (entity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;
        }

        public List<ProcessDefinitionEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ProcessDefinitionEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public void Insert(ProcessDefinitionEntity entity)
        {
            //if (entities.Any(z => z.Code == entity.Code))
            //    throw new CustomErrorException(ConstantsValue.DuplicateMsg, ConstantsValue.DuplicateCode);
            if (entities.Any(z => z.Title == entity.Title))
                throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
            entity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.ProcessDefinition) + LastInsertedID();
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(ProcessDefinitionEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
            SaveChanges();
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 35;
            return (entities.OrderBy(z => z.Id).Last().Id) + 35;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ProcessDefinitionEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            if (entities.Any(z => z.Id != entity.Id && z.Title == entity.Title))
                throw new CustomErrorException(ConstantsValue.DuplicateNameCode, ConstantsValue.DuplicateNameMsg);
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ProcessDefinitionEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }
    }
}
