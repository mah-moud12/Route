using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Model
{
    class Inst_course
    {
        public int Inst_id { get; set; }
        public int Course_id { get; set; }
        public string? Evaluation { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public Course Course { get; set; } = null!;

    }   
}
