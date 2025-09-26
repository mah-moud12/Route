using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Sales_Office.Model
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;


        //[ForeignKey(nameof(Sales__Office))]
        public int Office_Num { get; set; }


        [InverseProperty(nameof(Sales__Office.employees))]
        public Sales__Office Sales__Office { get; set; } = null!;



        [InverseProperty(nameof(Sales__Office.Manager))]
        public Sales__Office? Sales__OfficeManage { get; set; } 

    }
}
