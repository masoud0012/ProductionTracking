using OA.Data.Toural.FlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IFlowProcess
{
    public interface IFlowProcessRepository
    {
        List<FlowProcessEntity> GetALL();
        FlowProcessEntity Get(long id);
        List<FlowProcessEntity> Get(long[] id);
        FlowProcessEntity GetForActive(long id);
        FlowProcessEntity GetLastItem(Int64 UserID);
        long LastInsertedID();
        void Insert(FlowProcessEntity entity);
        void Update(FlowProcessEntity entity);
        void Delete(FlowProcessEntity entity);
        void Remove(FlowProcessEntity entity);
        List<FlowProcessEntity> GetQuery(Expression<Func<FlowProcessEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<FlowProcessEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(FlowProcessEntity entity);
    }
}
