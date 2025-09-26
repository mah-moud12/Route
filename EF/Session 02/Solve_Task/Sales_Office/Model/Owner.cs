using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Sales_Office.Model
{
    class Owner
    {
        [Key]
        public int Owner_Id { get; set; }
        public int Prop_id { get; set; }
        public decimal Precent { get; set; }
        public ICollection<Property_Owner> Property_Owners { get; set; } = new HashSet<Property_Owner>();
    }
}
