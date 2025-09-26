using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? PH_number { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();
        public ICollection<Musician_Instrument> Musician_Instruments { get; set; } = new HashSet<Musician_Instrument>();
        public ICollection<Musician_song> Musician_Songs { get; set; } = new HashSet<Musician_song>();
    }
}
