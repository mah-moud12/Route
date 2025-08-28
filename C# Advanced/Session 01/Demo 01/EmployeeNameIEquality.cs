using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class EmployeeNameIEquality : IEqualityComparer<Employee>
    {
        #region Manual
        //public new bool Equals(object? x, object? y)
        //{
        //    if (x is Employee employee && y is Employee employee1) 
        //    {
        //        return employee.Name == employee1.Name;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public int GetHashCode(object obj)
        //{
        //    Employee? employee = obj as Employee;
        //    return HashCode.Combine(employee?.Name);
        //} 
        #endregion

        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
}
