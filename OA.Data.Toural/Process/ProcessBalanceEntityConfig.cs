using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessBalanceEntityConfig : IEntityTypeConfiguration<ProcessBalanceEntity>
    {
        public void Configure(EntityTypeBuilder<ProcessBalanceEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.processBalanceStockEntities).WithOne(z => z.processBalanceEntity).HasForeignKey(z => z.ProcessBalanceID);

        }
    }
}
