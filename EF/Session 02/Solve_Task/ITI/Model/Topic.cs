using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Model
{
    class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
