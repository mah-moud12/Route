using Microsoft.EntityFrameworkCore;
using Solve_Task.Musican.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Data
{
    class MusicianDbContext:DbContext
    {
        public MusicianDbContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Musician01 ; Trusted_Connection = true ; TrustServerCertificate = true ");
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Album_Song> Album_Songs { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Musician_Instrument> Musician_Instruments { get; set; }
        public DbSet<Musician_song> Musician_Songs { get; set; }
        public DbSet<Song> Songs { get; set; }

    }
}
