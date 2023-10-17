using OA.Data.Toural.FlowProcess;
using OA.Service_.Toural.ViewModels.FlowProcess;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.FlowProcess
{
    public interface IFlowUsersSalaryService
    {
        FlowProcessVM Insert(FlowProcessDto body, FlowProcessEntity flowProcessEntity);
        FlowProcessVM Insert(FlowProcessDto body, FlowProcessEntity flowProcessEntity, ProcessVM processService);
        FlowProcessVM Edit(FlowProcessDto Entity);
        FlowProcessVM GetAll();
        FlowProcessVM GetByID(long Id);
        FlowProcessVM Remove(long[] id);
        FlowProcessVM Remove(long id);
        FlowProcessVM Active(long id);
        FlowProcessVM Search(FlowProcessDto body);
        void SaveChanges();
    }
}
