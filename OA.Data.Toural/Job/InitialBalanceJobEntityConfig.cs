using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Job
{
    public class InitialBalanceJobEntityConfig : IEntityTypeConfiguration<InitialBalanceJobEntity>
    {
        public void Configure(EntityTypeBuilder<InitialBalanceJobEntity> builder)
        {
            builder.HasKey(z => z.ID);
            builder.Property(z => z.WeightProductInCalculation).HasPrecision(7,5);
        }
    }
}
