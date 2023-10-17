using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public class ActionEntityConfiguration : IEntityTypeConfiguration<ActionsEntity>
    {
        public void Configure(EntityTypeBuilder<ActionsEntity> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValue(DateTime.Now);

        }
    }
}
