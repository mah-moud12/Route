using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    class Ward
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        //[ForeignKey(nameof(Nurse))]
        public int Nurse_Num { get; set; }
        public Nurse? Nurse { get; set; }

    }
}
