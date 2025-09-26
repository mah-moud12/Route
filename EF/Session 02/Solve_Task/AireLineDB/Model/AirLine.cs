using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    public class AirLine
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Contact_Person { get; set; }
        public string? Phone { get; set; }

    }
}
