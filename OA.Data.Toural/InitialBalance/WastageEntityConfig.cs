using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.InitialBalance
{
    public class WastageEntityConfig : IEntityTypeConfiguration<WastageEntity>
    {
        public void Configure(EntityTypeBuilder<WastageEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            
        }
    }
}
