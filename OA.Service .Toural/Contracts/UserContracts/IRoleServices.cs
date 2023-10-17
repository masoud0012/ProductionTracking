using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.Contracts.UserContracts
{
    public interface IRoleServices
    {
        RoleVM GetRoles();
        RoleVM Active(Int64 Id);
        RoleVM Remove(Int64 Id);
        RoleVM GetRole(long id);
        RoleVM InsertRole(RoleDto user);
        RoleVM UpdateRole(RoleDto user);
        RoleVM DeleteRole(long id);
    }
}
