using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Job
{
    public class CostJobEntityConfig : IEntityTypeConfiguration<CostJobEntity>
    {
        public void Configure(EntityTypeBuilder<CostJobEntity> builder)
        {
            builder.HasKey(z => z.ID);
        }
    }
}
