using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.Process
{
    public interface IProcessBalanceService
    {
        ProcessVM Insert(ProcessDto Entity);
        ProcessVM Edit(ProcessDto Entity);
        ProcessVM GetAll();
        ProcessVM GetByID(long Id);
        ProcessVM Remove(long[] id);
        ProcessVM GetByDto(ProcessDto body);
        ProcessVM Remove(long id);
        ProcessVM Active(long id);
        ProcessVM Search(ProcessDto body);
    }
}
