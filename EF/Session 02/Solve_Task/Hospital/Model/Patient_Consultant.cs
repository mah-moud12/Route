using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    [PrimaryKey(nameof(Patient_Id),nameof(Cons_Id))]
    class Patient_Consultant
    {
        //[ForeignKey(nameof(Patient))]
        public int Patient_Id { get; set; }
        //[ForeignKey(nameof(Consultant))]
        public int Cons_Id { get; set; }
        public Patient? Patient { get; set; }
        public Consultant? Consultant { get; set; }

    }
}
