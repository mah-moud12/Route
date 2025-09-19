using Microsoft.EntityFrameworkCore;
using Solve_Task.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Data
{
    class ITI_DbContext:DbContext
    {
        public ITI_DbContext():base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder sql)
        {
            sql.UseSqlServer("Data Source = . ; Initial Catalog = ITI_02 ; Integrated Security = true ; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Course_ID, ci.inst_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithOne(i => i.Departments)
                .HasForeignKey<Department>(d => d.Ins_ID);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }


    }
}
