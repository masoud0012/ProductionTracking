using OA.Data.UserEntity;
using OA.Service_.Toural.ViewModels.ControllVM;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.UserContracts
{
    public interface IUserService
    {
        UserVM GetUsers();
        UserVM Active(Int64 Id);
        UserVM Remove(Int64 Id);
        UserVM Remove(long[] Id);
        UserVM GetUser(long id);
        UserVM GetUsers(long[] ids);
        UserVM InsertUser(UserDto user);
        UserVM UpdateUser(UserDto user);

        UserVM ChangePassword(UserDto user);
        UserVM DeleteUser(long id);
        Task<UserVM> Login(UserDto user);
        UserVM Search(UserDto body);


    }
}
