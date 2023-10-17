using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IProcess
{
    public interface IProcessDefinitionRepository
    {
        List<ProcessDefinitionEntity> GetALL();
        ProcessDefinitionEntity Get(long id);
        ProcessDefinitionEntity GetForActive(long id);
        void Insert(ProcessDefinitionEntity entity);
        void Update(ProcessDefinitionEntity entity);
        void Delete(ProcessDefinitionEntity entity);
        void Remove(ProcessDefinitionEntity entity);
        long LastInsertedID();
        List<ProcessDefinitionEntity> GetQuery(Expression<Func<ProcessDefinitionEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<ProcessDefinitionEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(ProcessDefinitionEntity entity);
    }
}
