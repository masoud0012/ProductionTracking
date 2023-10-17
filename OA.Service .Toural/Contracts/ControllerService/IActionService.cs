using OA.Service_.Toural.ViewModels;
using OA.Service_.Toural.ViewModels.ControllVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.ControllerService
{
    public interface IActionService
    {
        ControllerVM GetActionsUser(Int64 userID);
        ControllerVM ChecHasAccess(Int64 userID, Int64 actionsID);
        ControllerVM Insert(ActionDto body);
        ControllerVM Edit(ActionDto Entity);
        ControllerVM GetAll(List<PersmissionActionsDto> PersmissionActionsDtos);
        ControllerVM GetByName(string actionName);
        ControllerVM GetByID(long Id);
        ControllerVM Remove(long[] id);
        ControllerVM Remove(long id);
        ControllerVM Active(long id);
        ControllerVM Search(ActionDto body);
        ControllerVM GrantAccessToUser(int userID);
        ControllerVM GetUserGrants(long userID, List<PersmissionActionsDto> PersmissionActionsDtos);
        ControllerVM SetUserGrants(ActionDto body);
        void SaveChanges();
    }
}
