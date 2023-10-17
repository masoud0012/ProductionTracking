using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IController
{
    public interface IActionRepository
    {
        List<ActionsEntity> GetALL();
        ActionsEntity Get(long id);
        List<ActionsEntity> Get(long[] id);
        ActionsEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(ActionsEntity entity);
        void Update(ActionsEntity entity);
        void Delete(ActionsEntity entity);
        void Remove(ActionsEntity entity);
        List<ActionsEntity> GetQuery(Expression<Func<ActionsEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<ActionsEntity> GetQueryData(Expression<Func<ActionsEntity, bool>> predicate);
        int GetQuery(Expression<Func<ActionsEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ActionsEntity entity);
    }
}
