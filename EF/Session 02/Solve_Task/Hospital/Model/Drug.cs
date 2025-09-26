using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    class Drug
    {
        [Key]
        public int Code { get; set; }
        public string? Dosage { get; set; }
        public string? Brand { get; set; }
        public ICollection<Patient_Drug_Nurse> Patient_Drug_Nurses { get; set; } = new HashSet<Patient_Drug_Nurse>();

    }
}
