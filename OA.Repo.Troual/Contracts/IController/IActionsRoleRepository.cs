using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IController
{
    public interface IActionsRoleRepository
    {
        List<ActionsRoleEntity> GetALL();
        ActionsRoleEntity Get(long id);
        List<ActionsRoleEntity> Get(long[] id);
        ActionsRoleEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(ActionsRoleEntity entity);
        void Update(ActionsRoleEntity entity);
        void Delete(ActionsRoleEntity entity);
        void Remove(ActionsRoleEntity entity);
        List<ActionsRoleEntity> GetQuery(Expression<Func<ActionsRoleEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<ActionsRoleEntity> GetQueryData(Expression<Func<ActionsRoleEntity, bool>> predicate);
        int GetQuery(Expression<Func<ActionsRoleEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ActionsRoleEntity entity);

    }
}
