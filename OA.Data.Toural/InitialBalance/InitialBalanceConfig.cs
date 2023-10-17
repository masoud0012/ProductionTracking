using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.InitialBalance
{
    public class InitialBalanceConfig : IEntityTypeConfiguration<InitialBalanceEntity>
    {
        public void Configure(EntityTypeBuilder<InitialBalanceEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.Title).HasMaxLength(100).IsRequired();
            builder.Property(z => z.WeighProductInCalculation).HasPrecision(7,5);
            builder.Property(z => z.Price).IsRequired();
            builder.HasMany(z => z.StockRoom_InitialBalanceEntity).WithOne(z => z.InitialBalanceEntities)
                .HasForeignKey(z => z.InitialBalanceEntitiesFK_ID).OnDelete(DeleteBehavior.Cascade);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.processBalanceEntities).WithOne(z => z.initialBalanceEntity).HasForeignKey(z => z.InitialBalanceID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.InitialBalanceJobEntities).WithOne(z => z.InitialBalanceEntity).HasForeignKey(z => z.InitialBalanceEntityID);

        }
    }
}
