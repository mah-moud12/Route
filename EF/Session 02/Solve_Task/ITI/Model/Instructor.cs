using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Model
{
    class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public decimal Hour_rate { get; set; }
        [ForeignKey(nameof(ContainIns))]
        public int Dept_Id { get; set; }
        public ICollection<Inst_course> Inst_Courses { get; set; } = new HashSet<Inst_course>();
        [InverseProperty(nameof(Department.Manager))]
        public Department? Department { get; set; }

        public Department ContainIns { get; set; } = null!;

    }
}
