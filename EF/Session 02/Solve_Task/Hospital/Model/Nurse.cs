using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    class Nurse
    {
        [Key]
        public int Number { get; set; }

        public string? Name { get; set; }
        public string? Address { get; set; }
        [ForeignKey(nameof(Ward))]
        public int Ward_Id { get; set; }
        public Ward? Ward { get; set; }

        public ICollection<Patient_Drug_Nurse> Patient_Drug_Nurses { get; set; } = new HashSet<Patient_Drug_Nurse>();


    }
}
