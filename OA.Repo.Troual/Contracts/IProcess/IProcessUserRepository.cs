using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IProcess
{
    public interface IProcessUserRepository
    {
        List<ProcessUserEntity> GetALL();
        ProcessUserEntity Get(long id);
        ProcessUserEntity GetForActive(long id);
        List<ProcessUserEntity> GetByProcessID(long id);
        void Insert(ProcessUserEntity entity);
        void Update(ProcessUserEntity entity);
        void Delete(ProcessUserEntity entity);
        void Remove(ProcessUserEntity entity);
        List<ProcessUserEntity> GetQuery(Expression<Func<ProcessUserEntity, bool>> predicate, int Page, int Row);
        int GetQuery(Expression<Func<ProcessUserEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ProcessUserEntity entity);
        List<ProcessUserEntity> GetByIds(long[] id);
    }
}
