using OA.Data.Toural.TableInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.ITableInfo
{
    public interface ITableInfoRepository
    {
        List<TableInfoEntity> GetALL();
        TableInfoEntity Get(long id);
        TableInfoEntity GetForActive(long id);
        void Insert(TableInfoEntity entity);
        void Update(TableInfoEntity entity);
        void Delete(TableInfoEntity entity);
        void Remove(TableInfoEntity entity);
        List<TableInfoEntity> GetQuery(Expression<Func<TableInfoEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<TableInfoEntity, bool>> predicate);
        void SaveChanges();

        void UpdateWithoutSave(TableInfoEntity entity);
    }
}
