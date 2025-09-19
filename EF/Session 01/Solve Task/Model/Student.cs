using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Model
{
    class Student
    {
        public int Id { get; set; }

        [Column("FName", TypeName = "VarChar"), StringLength(30, MinimumLength = 2), Required]
        public string? FirtsName { get; set; }
        [Column("LName", TypeName = "VarChar"), StringLength(30, MinimumLength = 2)]
        public string? LastName { get; set; }
        [StringLength(10, MinimumLength = 2), Column(TypeName = "VarChar")]
        public string? Address { get; set; }
        [MaxLength(50), MinLength(22)]
        public int Age { get; set; }
        public int Dept_Id { get; set; }
        public Department? Department { get; set; } 
    }
}
