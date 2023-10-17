using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IController
{
    public interface IControllerUserRepository
    {
        List<ControllerUserEntity> GetALL();
        ControllerUserEntity Get(long id);
        List<ControllerUserEntity> Get(long[] id);
        ControllerUserEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(ControllerUserEntity entity);
        void Update(ControllerUserEntity entity);
        void Delete(ControllerUserEntity entity);
        void Remove(ControllerUserEntity entity);
        List<ControllerUserEntity> GetQuery(Expression<Func<ControllerUserEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<ControllerUserEntity> GetQueryData(Expression<Func<ControllerUserEntity, bool>> predicate);
        int GetQuery(Expression<Func<ControllerUserEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ControllerUserEntity entity);
    }
}
