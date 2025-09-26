using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    [PrimaryKey(nameof(Musician_id),nameof(Inst_id))]
    class Musician_Instrument
    {
        [ForeignKey(nameof(Musician))]
        public int Musician_id { get; set; }

        [ForeignKey(nameof(Instrument))]
        public string Inst_id { get; set; } = null!;

        public Musician? Musician { get; set; }
        public Instrument? Instrument { get; set; }
    }
}
