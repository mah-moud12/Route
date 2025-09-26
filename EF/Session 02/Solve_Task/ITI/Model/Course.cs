using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Model
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(Topic))]
        public int Topic_Id { get; set; }
        public ICollection<Student_Course> Student_Courses { get; set; } = new HashSet<Student_Course>();
        public Topic Topic { get; set; } = null!;
        public ICollection<Inst_course> Inst_Courses { get; set; } = new HashSet<Inst_course>();

    }
}
