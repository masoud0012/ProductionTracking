using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.StockRoom
{
    public class StockRoomConfig : IEntityTypeConfiguration<StockRoomEntity>
    {
        public void Configure(EntityTypeBuilder<StockRoomEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValueSql("getdate()");
            builder.Property(z => z.Title).HasMaxLength(255).HasColumnName("Title").HasColumnType("nVarchar").IsRequired();
            builder.HasMany(z => z.StockRoom_InitialBalanceEntity).WithOne(z => z.StockRoomEntities).HasForeignKey(z => z.StockRoom_InitialBalanceFK_ID).OnDelete(DeleteBehavior.Cascade);
            
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
        }
    }
}
