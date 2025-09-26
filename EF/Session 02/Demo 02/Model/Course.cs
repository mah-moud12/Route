using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Model
{
    class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }  

        // Many - Many
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>(); // انا لو عملت كده في Many - Many صح برضو لان ال EF دكية وهتفهم وهيا من نفسها هتنشئ الجدول الفاصل علشان يحل مشكلة Many - Many 
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
