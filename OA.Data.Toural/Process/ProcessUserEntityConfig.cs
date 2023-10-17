using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessUserEntityConfig : IEntityTypeConfiguration<ProcessUserEntity>
    {
        public void Configure(EntityTypeBuilder<ProcessUserEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.flowProcessUserSalaryEntities).WithOne(z => z.processUserEntity).HasForeignKey(z => z.FlowProcessEntityID);
        }
    }
}
