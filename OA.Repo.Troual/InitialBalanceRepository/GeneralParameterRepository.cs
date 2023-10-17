using Microsoft.EntityFrameworkCore;
using OA.Common.Constants;
using OA.Common.EnumValues;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.InitialBalance;
using OA.Repo.Troual.BaseRepository;
using OA.Repo.Troual.Contracts.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.InitialBalanceRepository
{
    public class GeneralParameterRepository:IGeneralParameterRepository
    {
        private readonly TouralContext context;
        private DbSet<GeneralParameter> entities;
        public GeneralParameterRepository(TouralContext context) 
        {
            this.context = context;
            entities = context.Set<GeneralParameter>();
        }

        public void Delete(GeneralParameter entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public GeneralParameter Get(long id)
        {
            return entities.SingleOrDefault(z => z.Id == id&&z.IsEnabled==true);
        }

        public GeneralParameter GetParentById(long id)
        {
            return entities.SingleOrDefault(z => z.Id == id && z.IsEnabled == true&&z.ParentID==null);
        }

        public GeneralParameter GetParentByCode( ParentEnum parentEnum)
        {

            return entities.SingleOrDefault(z =>  z.IsEnabled == true && z.ParentID == null && z.Code == CommonUtility.GetParentType(parentEnum));
        }
        public GeneralParameter GetChild(long id, ParentEnum parentEnum)
        {

            return entities.SingleOrDefault(z => z.Id == id && z.IsEnabled == true&&z.ParentID!= null&&z.Parent.Code== CommonUtility.GetParentType(parentEnum));
        }
        public List<GeneralParameter> GetChildByParentID(long id)
        {

            return entities.Where(z => z.ParentID == id && z.IsEnabled == true).ToList();
        }

        public List<GeneralParameter> GetGeneralParameters()
        {
            return entities.Where(z=>z.IsEnabled==true).AsEnumerable().ToList();
        }

        public List<GeneralParameter> GetParametersParents()
        {
            return entities.Where(z => z.ParentID == null&&z.IsEnabled==true).ToList();
        }

        public List<GeneralParameter> GetGeneralParamterByParentCode(string Parent)
        {
            var parentEntity = GetParentByCode(Parent);
            return entities.Where(z => z.ParentID == parentEntity.Id && z.IsEnabled == true).ToList(); 
        }

        public void Insert(GeneralParameter entity)
        {
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entities.Add(entity);
        }

        public void Remove(GeneralParameter entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(GeneralParameter entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = DateTime.Now;
            context.Update(entity);
        }

        public List<GeneralParameter> GetQuery(Expression<Func<GeneralParameter, bool>> predicate, int Page, int Row,string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<GeneralParameter, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public GeneralParameter GetParentByCode(string Parent)
        {
            return entities.SingleOrDefault(z => z.ParentID == null && z.Code == Parent&&z.IsEnabled==true);
        }

        public GeneralParameter GetById(long ID)
        {
            var entity = entities.SingleOrDefault(z => z.Id == ID&&z.IsEnabled==true&&z.ParentID!=null);
            if (entity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;
        }

        public GeneralParameter GetChildById(long id)
        {
            return entities.SingleOrDefault(z => z.Id == id && z.IsEnabled == true&&z.ParentID!=null);
        }

        public GeneralParameter GetCParentByCodAndId(long id, string Code)
        {
            var entity = entities.SingleOrDefault(z => z.Id == id&&z.IsEnabled==true&&z.ParentID==null);
            if(entity==null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;

        }

        public GeneralParameter GetParentByCodeStr(string Parent)
        {
            return entities.SingleOrDefault(z => z.IsEnabled == true && z.ParentID == null && z.Code == Parent);

        }
    }
}
