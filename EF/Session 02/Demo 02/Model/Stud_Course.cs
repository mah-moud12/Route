using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Model
{
    //[PrimaryKey(nameof(StudId),nameof(CrsId))]
    class Stud_Course
    {
        public int StudId { get; set; }
        public int CrsId { get; set; }

        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;

    }
}
