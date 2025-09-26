using Microsoft.EntityFrameworkCore;
using Solve_Task.AireLineDB.Model;
using Solve_Task.Sales_Office.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Sales_Office.Data
{
    class Sales_OfficeDbContext:DbContext
    {
        public Sales_OfficeDbContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Employee>()
                        .HasOne(sal => sal.Sales__Office)
                        .WithMany(emp => emp.employees)
                        .HasForeignKey(emp => emp.Office_Num)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Model.Employee>()
                        .HasOne(sal => sal.Sales__OfficeManage)
                        .WithOne(emp => emp.Manager)
                        .HasForeignKey<Sales__Office>(emp => emp.Emp_id)
                        .OnDelete(DeleteBehavior.NoAction);


           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Sales_Office ; Trusted_Connection = true ; TrustServerCertificate = true ");
        }

        public DbSet<Model.Employee>  Employees{ get; set; }
        public DbSet<Owner>  Owners{ get; set; }
        public DbSet<Property>  Properties{ get; set; }
        public DbSet<Property_Owner>  property_Owners{ get; set; }
        public DbSet<Sales__Office>  Sales__Offices{ get; set; }


    }
}
