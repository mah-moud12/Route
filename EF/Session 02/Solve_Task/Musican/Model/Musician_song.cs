using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    [PrimaryKey(nameof(Mus_id),nameof(Song_title))]
    class Musician_song
    {
        [ForeignKey(nameof(Musician))]
        public int Mus_id { get; set; }
        [ForeignKey(nameof(Song))]
        public string Song_title { get; set; } = null!;
        public Song Song { get; set; } = null!;
        public Musician? Musician { get; set; }
    }
}
