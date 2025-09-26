using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Solve_Task.AireLineDB.Model;

namespace Solve_Task.AireLineDB.Data
{
    class AirLineDbContext:DbContext
    {

        public AirLineDbContext():base ()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder OB)
        {
            OB.UseSqlServer("Server = .; DataBase = AirLine ; Trusted_Connection = true; TrustServerCertificate=true");
        }

        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Aircraft_Route> Aircraft_Routes { get; set; }
        public DbSet<AireLinePhones> AireLinePhones { get; set; }
        public DbSet<Emp_Qualification> Emp_Qualifications { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


    }
}
