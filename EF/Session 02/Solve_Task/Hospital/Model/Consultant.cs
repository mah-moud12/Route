using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Patient_Consultant> Patient_Consultants { get; set; } = new HashSet<Patient_Consultant>();
    }
}
