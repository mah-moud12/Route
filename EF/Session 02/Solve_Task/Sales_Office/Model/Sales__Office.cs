using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Sales_Office.Model
{
    class Sales__Office
    {
        [Key]
        public int Number { get; set; }
        public string? Location { get; set; }
        //[ForeignKey(nameof(Manager))]
        public int Emp_id { get; set; }
        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();
        public Employee Manager { get; set; } = null!;

        public ICollection<Property> Properties { get; set; } = new HashSet<Property>();

    }
}
