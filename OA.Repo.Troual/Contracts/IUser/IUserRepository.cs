using OA.Data.UserEntity;
using OA.Repo.Troual.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.Contracts.IUser
{
    public interface IUserRepository 
    {
        List<User> GetQuery(Expression<Func<User, bool>> predicate,  int Page, int Row, string orderBy);
        int GetQuery(Expression<Func<User, bool>> predicate);
    }
}
