//using Common;
using Demo_02.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Configurations
{
    class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department", "Sales");
            builder.HasKey(d => d.DeptId);
            builder.Property(d => d.DeptId)
                    //.ValueGeneratedNever()
                    .UseIdentityColumn(10, 10);

            builder.Property(Dept => Dept.DeptName)
                 .HasColumnName("DepartmentName")
                 .HasDefaultValue("HR")
                 .HasMaxLength(50)
                 .IsRequired(false);

            builder.Property(d => d.DateOfCreation)
                .HasAnnotation("DataType", "Date")
                //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now)); // NO 
                .HasDefaultValueSql("GetDate()");

            builder.Ignore(D=>D.Serial);

        }
    }
}
