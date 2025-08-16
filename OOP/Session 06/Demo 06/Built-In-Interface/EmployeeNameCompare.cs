using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_06.Built_In_Interface
{
    class EmployeeNameCompare : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
             int res=string.Compare(x?.Name , y?.Name); 
            if(res==0)
               return  decimal.Compare(x.Salary, y.Salary);
            else
                return string.Compare(x?.Name, y?.Name);
        }
    }
}
