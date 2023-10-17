using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.Toural.TableInfo;
using OA.Repo.Troual.Contracts.ITableInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.TableInfo
{
    public class TableInfoRepository: ITableInfoRepository
    {
        private readonly TouralContext context;
        private DbSet<TableInfoEntity> entities;
        public TableInfoRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<TableInfoEntity>();
        }

        public void Delete(TableInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        public TableInfoEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<TableInfoEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public TableInfoEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public List<TableInfoEntity> GetQuery(Expression<Func<TableInfoEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<TableInfoEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public void Insert(TableInfoEntity entity)
        {
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(TableInfoEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(TableInfoEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(TableInfoEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }
    }
}
