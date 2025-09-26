using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    class Instrument
    {
        [Key]
        public string Name { get; set; } = null!;
        public string? Key { get; set; }
        public ICollection<Musician_Instrument> Musician_Instruments { get; set; } = new HashSet<Musician_Instrument>();
    }
}
