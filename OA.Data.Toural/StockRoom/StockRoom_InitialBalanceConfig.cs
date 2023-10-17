using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.StockRoom
{
    public class StockRoom_InitialBalanceConfig : IEntityTypeConfiguration<StockRoom_InitialBalanceEntity>
    {
        public void Configure(EntityTypeBuilder<StockRoom_InitialBalanceEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.processBalanceEntities).WithOne(z => z.stockRoom_InitialBalanceEntity).HasForeignKey(z => z.stockRoom_InitialBalanceID);
            builder.HasMany(z => z.flowPorcessStockInitialEntities).WithOne(z => z.stockRoom_InitialBalanceEntity).HasForeignKey(z => z.stockRoom_InitialBalanceEntityID);
        }
    }
}

