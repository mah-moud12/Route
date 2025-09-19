using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Model
{
    class Topic
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20, MinimumLength = 2), Required]
        public string? Name { get; set; }
    }
}
