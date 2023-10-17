using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IProcess
{
    public interface IProcessRepository
    {
        List<ProcessEntity> GetALL();
        ProcessEntity Get(long id);
        ProcessEntity GetForActive(long id);
        void Insert(ProcessEntity entity);
        void Update(ProcessEntity entity);
        void Delete(ProcessEntity entity);
        void Remove(ProcessEntity entity);
        ProcessEntity GetLastItem(Int64 UserID);
        List<ProcessEntity> GetQuery(Expression<Func<ProcessEntity, bool>> predicate, int Page, int Row, string orderBy, int status);
        int GetQuery(Expression<Func<ProcessEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ProcessEntity entity);
        public long LastInsertedID();
    }
}
