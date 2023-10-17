using OA.Data.Toural.FlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.Contracts.IFlowProcess
{
    public interface IFlowProcessStockInitialRepository
    {
        List<FlowProcessStockInitialEntity> GetALL();
        FlowProcessStockInitialEntity Get(long id);
        List<FlowProcessStockInitialEntity> Get(long[] id);
        FlowProcessStockInitialEntity GetForActive(long id);
        long LastInsertedID();
        void Insert(FlowProcessStockInitialEntity entity);
        void Update(FlowProcessStockInitialEntity entity);
        void Delete(FlowProcessStockInitialEntity entity);
        void Remove(FlowProcessStockInitialEntity entity);
        List<FlowProcessStockInitialEntity> GetQuery(Expression<Func<FlowProcessStockInitialEntity, bool>> predicate, int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<FlowProcessStockInitialEntity, bool>> predicate);
        void SaveChanges();
        void UpdateWithoutSave(FlowProcessStockInitialEntity entity);
    }
}
