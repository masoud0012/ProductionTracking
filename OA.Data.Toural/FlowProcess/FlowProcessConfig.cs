using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.FlowProcess
{
    public class FlowProcessConfig : IEntityTypeConfiguration<FlowProcessEntity>
    {
        public void Configure(EntityTypeBuilder<FlowProcessEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.flowProcessUserSalaryEntities).WithOne(z => z.FlowProcessEntity).HasForeignKey(z => z.FlowProcessEntityID);
            builder.HasOne(z => z.InitialBalanceEntity).WithOne(z => z.flowProcessEntity).HasForeignKey<InitialBalance.InitialBalanceEntity>(b => b.flowProcessEntityID); ;
            builder.HasMany(z => z.flowPorcessStockInitialEntities).WithOne(z => z.FlowProcessEntity).HasForeignKey(z => z.FlowProcessEntityID);
        }
    }
}
