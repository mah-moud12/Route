using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfBarth { get; set; }
        [ForeignKey(nameof(Ward))]
        public int Ward_Id { get; set; }
        [ForeignKey(nameof(Consultant))]
        public int Cons_Id { get; set; }

        public Ward? Ward { get; set; }
        public Consultant? Consultant { get; set; }

        public ICollection<Patient_Consultant> Patient_Consultants { get; set; }= new HashSet<Patient_Consultant>();
        public ICollection<Patient_Drug_Nurse> Patient_Drug_Nurses { get; set; } = new HashSet<Patient_Drug_Nurse>();


    }
}
