using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class EmployeeIEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y) => x?.Id.Equals(y?.Id) ?? false;

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
