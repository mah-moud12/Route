using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    class Album_Song
    {
        [ForeignKey(nameof(Album))]
        [Key]
        public int Album_id { get; set; }


        [ForeignKey(nameof(Song))]
        public string song_title { get; set; } = null!;

        public Album Album { get; set; } = null!;
        public Song? Song { get; set; }
    }
}
