using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    class Song
    {
        [Key]
        public string Title { get; set; } = null!;
        public string? Author { get; set; }
        public Album_Song? Album_Song { get; set; }
        public ICollection<Musician_song> Musician_Songs { get; set; } = new HashSet<Musician_song>();
    }
}
