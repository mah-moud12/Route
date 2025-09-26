using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Sales_Office.Model
{
    [PrimaryKey(nameof(Owner_Id),nameof(Prop_id))]
    class Property_Owner
    {
        public int Owner_Id { get; set; }
        public int Prop_id { get; set; }
        public decimal Precent { get; set; }
        public Owner Owner { get; set; } = null!;
        public Property Property { get; set; } = null!;
    }
}
