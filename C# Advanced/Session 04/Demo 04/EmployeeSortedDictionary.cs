using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class EmployeeSortedDictionary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
            =>  y?.Salary.CompareTo(x?.Salary) ?? -1;
        
    }
}
