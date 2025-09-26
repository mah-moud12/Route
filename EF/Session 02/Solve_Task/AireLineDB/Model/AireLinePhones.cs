using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    class AireLinePhones
    {
        [ForeignKey(nameof(AireLine_Phone))]
        public int AL_Id { get; set; }
        public string? Phone { get; set; }  
        public AirLine AireLine_Phone { get; set; } = null!;
    }
}
