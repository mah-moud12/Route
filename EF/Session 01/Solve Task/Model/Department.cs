using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Model
{
    class Department
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20,MinimumLength =2), Required]
        public string? Name { get; set; }
        [ForeignKey(nameof(Instructor))]
        public int Ins_ID { get; set; }
        public Instructor? Instructor { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
