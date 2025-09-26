using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Model
{
    class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string? LName { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        [ForeignKey(nameof(Department)),InverseProperty(nameof(Department.Students))]
        public int Dept_Id { get; set; }
        public ICollection<Student_Course> Student_Courses { get; set; } = new HashSet<Student_Course>();
        public Department Department { get; set; } = null!;
    }
}
