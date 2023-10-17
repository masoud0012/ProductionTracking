using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.InitialBalance
{
    public class GeneralParameterConfig : IEntityTypeConfiguration<GeneralParameter>
    {
        public void Configure(EntityTypeBuilder<GeneralParameter> builder)
        {
            builder.HasKey(z => z.Id);
            builder.Property(z => z.AddedDate).HasDefaultValueSql("getdate()");
            builder.HasMany(z => z.Children).WithOne(z => z.Parent).HasForeignKey(z => z.ParentID);
            builder.Property(z => z.Code).IsRequired();
            builder.Property(z => z.Title).HasMaxLength(400).IsRequired();
            builder.HasMany(z => z.InitialBalance_UnitMeasurement).WithOne(z => z.UnitMeasurement).HasForeignKey(z => z.UnitMeaurementFK_ID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.InitialBalance_TypeMaterial).WithOne(z => z.TypeMaterial).HasForeignKey(z => z.TypeMaterialFK_ID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.InitialBalance_CategoryTypes).WithOne(z => z.CategoryType).HasForeignKey(z => z.CategoryTypeFK_ID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.Emplooyers).WithOne(z => z.EmployeerType).HasForeignKey(z => z.EmployeerTypeFK_ID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.Emplooyers_Salary).WithOne(z => z.SalaryType).HasForeignKey(z => z.SalaryTypeFK_ID).OnDelete(DeleteBehavior.NoAction);
            builder.Property(z => z.IsEnabled).HasDefaultValue(true);
            builder.HasMany(z => z.Contractors).WithOne(z => z.ContractorType).HasForeignKey(z => z.ContractorTypeID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(z => z.wastageEntities).WithOne(z => z.UnitMeasurement).HasForeignKey(z => z.UnitMeaurementFK_ID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
