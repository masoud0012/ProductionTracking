using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.UserEntity
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.HasMany(z => z.processUserEntities).WithOne(z => z.user).HasForeignKey(z => z.UserID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.ControllerUserEntities).WithOne(z => z.UserEntity).HasForeignKey(z => z.UserEntityID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.ActionsUserEntities).WithOne(z => z.UserEntity).HasForeignKey(z => z.UserEntityID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.LogEntities).WithOne(z => z.User).HasForeignKey(z => z.UserID);
        }
    }
}
