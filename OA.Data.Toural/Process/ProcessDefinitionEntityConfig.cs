using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessDefinitionEntityConfig : IEntityTypeConfiguration<ProcessDefinitionEntity>
    {
        public void Configure(EntityTypeBuilder<ProcessDefinitionEntity> builder)
        {
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);
            builder.HasMany(z => z.ProcessEntities).WithOne(z => z.processDefinitionEntity).HasForeignKey(z => z.processDefinitionEntityID);
        }
    }
}
