using OA.Data.Toural.LogEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.ILogEntity
{
    public interface ILogEntityRepository
    {
        List<LogEntity> GetALL();
        LogEntity Get(long id);
        List<LogEntity> Get(long[] id);
        LogEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(LogEntity entity);
        void Update(LogEntity entity);
        void Delete(LogEntity entity);
        void Remove(LogEntity entity);
        List<LogEntity> GetQuery(Expression<Func<LogEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<LogEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(LogEntity entity);
        LogEntity GetLastItem(Int64 UserID);
        List<LogEntity> GetQueryData(Expression<Func<LogEntity, bool>> predicate);
        List<LogEntity> GetQueryData(Expression<Func<LogEntity, bool>> predicate, int Page, int Row);
    }
}
