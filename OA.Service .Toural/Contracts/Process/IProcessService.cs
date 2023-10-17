using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.Process
{
    public  interface IProcessService
    {
        ProcessVM Insert(ProcessDto Entity);
        ProcessVM InsertBalance(ProcessBalanceDto body);
        ProcessVM EditBalance(ProcessBalanceDto body); 
        ProcessVM Edit(ProcessDto Entity);
        ProcessVM GetAll();
        ProcessVM GetByID(long Id);
        ProcessVM GetPDF(long Id);
        ProcessVM Remove(long[] id);
        ProcessDto GetUserContractors(long Id);
        ProcessDto GetProcessBalances(long Id);

        ProcessVM Remove(long id);
        ProcessVM RolBackProcess(long id);
        ProcessVM Active(long id);
        ProcessVM Search(ProcessDto body);
    }
}
