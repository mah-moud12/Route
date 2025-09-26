using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    class Route
    {
        public int Id { get; set; }
        public decimal Distance { get; set; }
        public string? Origin { get; set; }
        public int Classification { get; set; }


    }
}
