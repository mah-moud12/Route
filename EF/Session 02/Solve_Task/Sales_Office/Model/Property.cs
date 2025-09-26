using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Sales_Office.Model
{
    class Property
    {
        public int Id { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? Code { get; set; }
        [ForeignKey(nameof(Sales__Office))]
        public int Office_Num { get; set; }
        public Sales__Office Sales__Office { get; set; } = null!;

        public ICollection<Property_Owner> Property_Owners { get; set; } = new HashSet<Property_Owner>();

    }
}
