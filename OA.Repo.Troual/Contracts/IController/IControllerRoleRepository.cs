using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IController
{
    public  interface IControllerRoleRepository
    {
        List<ControllerRoleEntity> GetALL();
        ControllerRoleEntity Get(long id);
        List<ControllerRoleEntity> Get(long[] id);
        ControllerRoleEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(ControllerRoleEntity entity);
        void Update(ControllerRoleEntity entity);
        void Delete(ControllerRoleEntity entity);
        void Remove(ControllerRoleEntity entity);
        List<ControllerRoleEntity> GetQuery(Expression<Func<ControllerRoleEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<ControllerRoleEntity> GetQueryData(Expression<Func<ControllerRoleEntity, bool>> predicate);
        int GetQuery(Expression<Func<ControllerRoleEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ControllerRoleEntity entity);
    }
}
