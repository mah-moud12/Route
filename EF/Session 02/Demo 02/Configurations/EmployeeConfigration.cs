using Demo_02.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Configurations
{
    class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasKey(emp => emp.EmpId);
            //builder.Property("Name"); // Unsafe
            builder.Property(emp => emp.Name);
            builder.Property(nameof(Employee.Name))
                    .HasColumnName("EmpName")
                    .HasColumnType("VarChar")
                    .HasMaxLength(50)
                    .IsRequired(false);



            #region One-one [Both mendatory]
            builder.OwnsOne(emp => emp.Address, Address => Address.WithOwner());

            #endregion
            // One - Many
            builder.HasOne(emp => emp.Department)
                    .WithMany(d => d.employees)
                    .HasForeignKey/*<Employee>*/(emp => emp.empDepartment) // متحطش ال Generic لانه بيعرف لوحده في العلاقة ال One - Many طب لي كنت بحددها في قبل كده علشان كانت One-One فكنت لازم افهمه مين ال FK
                    .IsRequired(true)
                    .OnDelete(DeleteBehavior.NoAction);


        }
    }       
}
