using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IController
{
   public interface IControllerRepository
    {
        List<ControllerEntity> GetALL();
        ControllerEntity Get(long id);
        List<ControllerEntity> Get(long[] id);
        ControllerEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(ControllerEntity entity);
        void Update(ControllerEntity entity);
        void Delete(ControllerEntity entity);
        void Remove(ControllerEntity entity);
        List<ControllerEntity> GetQuery(Expression<Func<ControllerEntity, bool>> predicate, int Page, int Row, string orderBy);
        List<ControllerEntity> GetQueryData(Expression<Func<ControllerEntity, bool>> predicate);
        int GetQuery(Expression<Func<ControllerEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ControllerEntity entity);
    }
}
