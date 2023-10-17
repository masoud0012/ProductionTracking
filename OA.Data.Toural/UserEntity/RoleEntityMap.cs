using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Data.Toural.UserEntity
{
    public class RoleEntityMap : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.Id).ValueGeneratedOnAdd();
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.ControllerRoleEntities).WithOne(z => z.RoleEntity).HasForeignKey(z => z.RoleEntityID);
            builder.HasMany(z => z.ActionsRoleEntities).WithOne(z => z.RoleEntity).HasForeignKey(z => z.RoleEntityID);
        }
    }
}
