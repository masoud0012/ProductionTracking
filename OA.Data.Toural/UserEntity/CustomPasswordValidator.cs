using Microsoft.AspNetCore.Identity;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.UserEntity
{
    public class CustomPasswordValidator : IPasswordValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsUserName",
                    Description = "Password cannot contain username"
                });

            }
            return Task.FromResult(errors.Count ==0?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
