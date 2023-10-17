using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessEntityConfig : IEntityTypeConfiguration<ProcessEntity>
    {
        public void Configure(EntityTypeBuilder<ProcessEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);

            builder.Property(z => z.IsEnabled).HasDefaultValue(true);

            builder.HasMany(z => z.processBalanceEntities).WithOne(z => z.processEntity).HasForeignKey(z => z.processEntityID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(z => z.flowProcessEntities).WithOne(z => z.processEntity).HasForeignKey(z => z.processEntityID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(z => z.UserContractors).WithOne(z => z.processEntity).HasForeignKey(z => z.processEntityID).OnDelete(DeleteBehavior.Cascade);

        }

    }
}
