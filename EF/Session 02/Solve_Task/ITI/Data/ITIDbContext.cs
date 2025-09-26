using Microsoft.EntityFrameworkCore;
using Solve_Task.ITI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Data
{
    class ITIDbContext:DbContext
    {

        public ITIDbContext()
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Department>()
                        .HasOne(ins => ins.Manager)
                        .WithOne(dept => dept.Department)
                        .HasForeignKey<Department>(dept => dept.ManagerId)
                        .OnDelete(DeleteBehavior.NoAction);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI01 ; Trusted_Connection = true ; TrustServerCertificate = true ");
        }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }
        //public DbSet<Inst_course> Inst_Courses { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Student_Course> Student_Courses { get; set; }
        //public DbSet<Topic> Topics { get; set; }
    }
}
