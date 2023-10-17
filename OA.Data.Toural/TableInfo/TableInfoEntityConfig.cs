using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.TableInfo
{
    public class TableInfoEntityConfig : IEntityTypeConfiguration<TableInfoEntity>
    {
        public void Configure(EntityTypeBuilder<TableInfoEntity> builder)
        {
        }
    }
}
