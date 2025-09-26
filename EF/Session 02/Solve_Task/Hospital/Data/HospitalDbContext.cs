using Microsoft.EntityFrameworkCore;
using Solve_Task.Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Data
{
    class HospitalDbContext:DbContext
    {
        public HospitalDbContext() : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient_Consultant>()
                .HasOne(p => p.Patient)
                .WithMany(p => p.Patient_Consultants)   
                .HasForeignKey(p => p.Patient_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patient_Consultant>()
                        .HasOne(p => p.Consultant)
                        .WithMany(c => c.Patient_Consultants)  
                        .HasForeignKey(p => p.Cons_Id)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patient_Drug_Nurse>()
                        .HasOne(pdn => pdn.Patient)
                        .WithMany(p => p.Patient_Drug_Nurses)
                        .HasForeignKey(pdn => pdn.Patient_Id)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Patient_Drug_Nurse>()
                        .HasOne(pdn => pdn.Nurse)
                        .WithMany(nur=>nur.Patient_Drug_Nurses)
                        .HasForeignKey(pdn => pdn.Nurse_Number)
                        .OnDelete(DeleteBehavior.NoAction);

             modelBuilder.Entity<Patient_Drug_Nurse>()
                        .HasOne(pdn => pdn.Drug)
                        .WithMany(nur=>nur.Patient_Drug_Nurses)
                        .HasForeignKey(pdn => pdn.Drug_Code)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Nurse>()
                        .HasOne(nur => nur.Ward)
                        .WithOne(war => war.Nurse)
                        .HasForeignKey<Ward>(ward => ward.Nurse_Num)
                        .OnDelete(DeleteBehavior.NoAction);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder OB)
        {
            OB.UseSqlServer("Server = DESKTOP-0GJAUP2; DataBase = Hospital ; Trusted_Connection = true; TrustServerCertificate=true");
        }

        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Drug_Brand> Drug_Brands { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Patient_Consultant> Patient_Consultants{ get; set; }
        public DbSet<Patient_Drug_Nurse> Patient_Drug_Nurses { get; set; }
        public DbSet<Ward> Wards{ get; set; }

    }
}
