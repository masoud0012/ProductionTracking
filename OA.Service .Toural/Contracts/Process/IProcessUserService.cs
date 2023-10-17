using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.Process
{
    public interface IProcessUserService
    {
        ProcessVM Insert(ProcessUserDto Entity);
        ProcessVM Edit(ProcessUserDto Entity);
        ProcessVM GetAll();
        ProcessVM GetByID(long Id);
        ProcessVM GetByIDs(long[] Id);
        ProcessVM Remove(long[] id);
        ProcessVM Remove(long id);
        ProcessVM Active(long id);
        ProcessVM Search(ProcessUserDto body);
    }
}
