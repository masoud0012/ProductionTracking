using OA.Data.Toural.FlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IFlowProcess
{
    public  interface IFlowProcessUserSalaryRepository
    {
        List<FlowProcessUserSalaryEntity> GetALL();
        FlowProcessUserSalaryEntity Get(long id);
        FlowProcessUserSalaryEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(FlowProcessUserSalaryEntity entity);
        void Update(FlowProcessUserSalaryEntity entity);
        void Delete(FlowProcessUserSalaryEntity entity);
        void Remove(FlowProcessUserSalaryEntity entity);
        List<FlowProcessUserSalaryEntity> GetQuery(Expression<Func<FlowProcessUserSalaryEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<FlowProcessUserSalaryEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(FlowProcessUserSalaryEntity entity);
    }
}
