using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    class AirCraft
    {

        public int Id { get; set; }
        public int Capacity { get; set; }
        public string?  Model { get; set; }
        public string? Maj_pilot { get; set; }
        public string?  Host1 { get; set; }
        public string?  Host2 { get; set; }

    }
}
