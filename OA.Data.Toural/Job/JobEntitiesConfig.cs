using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Job
{
    public class JobEntitiesConfig : IEntityTypeConfiguration<JobEntities>
    {
        public void Configure(EntityTypeBuilder<JobEntities> builder)
        {
            builder.HasKey(z => z.JobEntityID);
            builder.Property(z => z.WeighProductInCalculation).HasPrecision(7,5);
            builder.Property(z => z.WeightInCalculation).HasPrecision(7,5);
            builder.Property(z => z.ExecutedDate).HasDefaultValue(DateTime.Now);
            builder.HasMany(z => z.CostJobEntities).WithOne(z => z.JobEntitiy).HasForeignKey(z => z.JobEntityID);
            builder.HasMany(z => z.InitialBalanceJobEntities).WithOne(z => z.JobEntitiy).HasForeignKey(z => z.JobEntityID);

        }
    }
}
