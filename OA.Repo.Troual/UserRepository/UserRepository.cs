using Microsoft.EntityFrameworkCore;
using OA.Common.Utility;
using OA.Data.UserEntity;
using OA.Repo.Troual.Contracts.IUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly TouralContext context;
        private DbSet<User> entities;
        public UserRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<User>();
        }

        public List<User> GetQuery(Expression<Func<User, bool>> predicate, int Page, int Row,string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<User, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }
    }
}
