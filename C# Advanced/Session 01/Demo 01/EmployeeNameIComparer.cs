using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class EmployeeNameIComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (y is null && x is null) return 0;
            else if (y is null) return 1;
            else if (x is null) return -1;

            return x.Name!.CompareTo(y.Name);
        }
    }
}
