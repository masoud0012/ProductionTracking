using OA.Service_.Toural.ViewModels;
using OA.Service_.Toural.ViewModels.ControllVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.ControllerService
{
    public interface IControllService
    {
        ControllerVM GetController(Int64 userID);
        ControllerVM Insert(ControllerDto body);
        ControllerVM Edit(ControllerDto Entity);
        ControllerVM GetAll(List<PersmissionActionsDto> PersmissionActionsDtos);
        ControllerVM GetByName(string controllerName);
        ControllerVM GetByID(long Id);
        ControllerVM Remove(long[] id);
        ControllerVM Remove(long id);
        ControllerVM Active(long id);
        ControllerVM Search(ControllerDto body);
        ControllerVM GrantAccessToUser(Int64 userID);
        ControllerVM GetUserGrants(Int64 userID);
        void SaveChanges();
    }
}
