using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    [PrimaryKey(nameof(Code),nameof(Brand))]
    class Drug_Brand
    {
        [ForeignKey(nameof(Drug))]
        public int Code { get; set; }
        public string? Brand { get; set; }
        public Drug? Drug { get; set; }
    }
}
