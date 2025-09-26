using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    class Emp_Qualification
    {
        [ForeignKey(nameof(Employee))]
        public int Emp_Id { get; set; }
        public string? Qualification { get; set; }
        public Employee? Employee { get; set; }
    }
}
