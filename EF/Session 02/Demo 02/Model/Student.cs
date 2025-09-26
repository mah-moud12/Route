using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Model
{
    class Student
    {
        public int Id { get; set; }  // By Convention
        public string Name { get; set; } = null!; // By Convention => nVarChar(max)
        public int Age { get; set; } // By Conventioa => Int
                                     // Many - Many
       //public ICollection<Course> Courses { get; set; } = new HashSet<Course>();//By Convention انا لو عملت كده في Many - Many صح برضو لان ال EF دكية وهتفهم وهيا من نفسها هتنشئ الجدول الفاصل علشان يحل مشكلة Many - Many 
                                     //  لما اعمل كده ومعملش Create Class بكون غرضي انا مش مضطر امسك ال Entity اما لو عاوز امسك ال Entity  لازم اعمل Create Domain Model 
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
