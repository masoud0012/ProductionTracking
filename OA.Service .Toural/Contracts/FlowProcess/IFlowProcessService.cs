using Microsoft.AspNetCore.Http;
using OA.Service_.Toural.ViewModels.FlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.FlowProcess
{
    public interface IFlowProcessService
    {
        FlowProcessVM InsertToStack(FlowProcessDto Entity);
        FlowProcessVM InsertNewBalance(FlowProcessDto body, IFormFile formFile);
        FlowProcessVM InsertWastages(FlowProcessDto body);
        FlowProcessVM Edit(FlowProcessDto Entity);
        FlowProcessVM GetAll();
        FlowProcessVM GetByID(long Id);
        FlowProcessVM Remove(long[] id);
        FlowProcessVM Remove(long id);
        FlowProcessVM Active(long id);
        FlowProcessVM Search(FlowProcessDto body);
    }
}
