using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public class ControllerRoleEntityConfiguration : IEntityTypeConfiguration<ControllerRoleEntity>
    {
        public void Configure(EntityTypeBuilder<ControllerRoleEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
        }
    }
}
