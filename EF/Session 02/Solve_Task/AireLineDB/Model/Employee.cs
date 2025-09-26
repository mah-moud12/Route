using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public Gender Gender { get; set; }
        public string Position { get; set; } = null!;
        public string? Qualifications { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        [ForeignKey(nameof(Emp_Air))]
        public int? AL_Id { get; set; }
        public AireLineDB.Model.AirLine? Emp_Air{ get; set; }


    }
}
