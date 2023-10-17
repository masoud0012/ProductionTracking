using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Cost
{
    public class CostEntityConfiguration : IEntityTypeConfiguration<CostEntity>
    {
        public void Configure(EntityTypeBuilder<CostEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.CostJobEntities).WithOne(z => z.CostEntity).HasForeignKey(z => z.CostEntityID);
        }
    }
}
