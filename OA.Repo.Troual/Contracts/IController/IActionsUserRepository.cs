using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IController
{
    public interface IActionsUserRepository
    {

        List<ActionsUserEntity> GetALL();
        ActionsUserEntity Get(long id);
        List<ActionsUserEntity> Get(long[] id);
        ActionsUserEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(ActionsUserEntity entity);
        void Update(ActionsUserEntity entity);
        void Delete(ActionsUserEntity entity);
        void Remove(ActionsUserEntity entity);
        List<ActionsUserEntity> GetQuery(Expression<Func<ActionsUserEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<ActionsUserEntity> GetQueryData(Expression<Func<ActionsUserEntity, bool>> predicate);
        int GetQuery(Expression<Func<ActionsUserEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ActionsUserEntity entity);
    }
}

