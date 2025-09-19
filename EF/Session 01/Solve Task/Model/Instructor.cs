using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Model
{
    class Instructor
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20, MinimumLength = 2), Required]
        public string? Name { get; set; }
        [MaxLength(1), MinLength(3)]
        public int Bouns { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Salary { get; set; }
        [StringLength(10, MinimumLength = 2), Column(TypeName = "VarChar")]
        public string? Address { get; set; }
        [Column(TypeName = "decimal(4,1)")]
        public decimal HouRate { get; set; }
        [ForeignKey(nameof(Department))]
        public int Dept_Id { get; set; }
        public Department? Departments { get; set; }


    }
}
