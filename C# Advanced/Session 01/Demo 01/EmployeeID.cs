﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class EmployeeID : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x is null && y is null) return 0;
            if (x is null) return -1;
            if (y is null) return 1;

            return x.Id.CompareTo(y.Id);
        }
    }
}
