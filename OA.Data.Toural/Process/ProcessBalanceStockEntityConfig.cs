using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessBalanceStockEntityConfig : IEntityTypeConfiguration<ProcessBalanceStockEntity>
    {
        public void Configure(EntityTypeBuilder<ProcessBalanceStockEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
        }
    }
}
