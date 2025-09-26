using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Model
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Hiring_date { get; set; }
        [InverseProperty(nameof(Manager.Department))]
        public int ManagerId { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public Instructor Manager { get; set; } = null!;
        public ICollection<Instructor> Inst_Courses { get; set; } = new HashSet<Instructor>();

    }
}
