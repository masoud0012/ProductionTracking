using OA.Data.Toural.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.InitialBalance
{
    public interface IWastageRepository
    {
        List<WastageEntity> GetAll();
        List<WastageEntity> GetAllValue();
        WastageEntity Get(long id);
        List<WastageEntity> Get(long[] id);
        WastageEntity Insert(WastageEntity entity);
        void Update(WastageEntity entity);
        void Delete(WastageEntity entity);
        void Remove(WastageEntity entity);
        void SaveChanges();
        long LastInsertedID();
        WastageEntity getForRemove(long id);
        List<WastageEntity> GetQuery(Expression<Func<WastageEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<WastageEntity> GetQueryGroupBy(Expression<Func<WastageEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<WastageEntity, bool>> predicate);
    }
}
