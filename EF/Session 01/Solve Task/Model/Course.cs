using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Model
{
    class Course
    {

        [Key]
        public int ID { get; set; }
        [StringLength(20, MinimumLength = 2), Required]
        public string? Name { get; set; }
        [StringLength(200, MinimumLength = 5), Required]
        public string? Description { get; set; }
        public int Duration { get; set; }
        [ForeignKey(nameof(Topic))]
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }

    }
}
