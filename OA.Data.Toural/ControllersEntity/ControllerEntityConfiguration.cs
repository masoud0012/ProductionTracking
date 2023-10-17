using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public class ControllerEntityConfiguration : IEntityTypeConfiguration<ControllerEntity>
    {
        public void Configure(EntityTypeBuilder<ControllerEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.HasMany(z => z.ActionsEntities).WithOne(z => z.ControllerEntity).HasForeignKey(z => z.ControllerEntityID);
            builder.HasMany(z => z.ControllerRoleEntities).WithOne(z => z.ControllerEntity).HasForeignKey(z => z.ControllerEntityID);
            builder.HasMany(z => z.ControllerUserEntities).WithOne(z => z.ControllerEntity).HasForeignKey(z => z.ControllerEntityID);
        }
    }
}
