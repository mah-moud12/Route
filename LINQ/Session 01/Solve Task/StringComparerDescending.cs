using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class StringComparerDescending : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x is null && y is null) return 0;
            else if (y is null) return -1;
            else if (x is null) return 1;
            return y.ToLower().CompareTo(x.ToLower());
        }
    }
}
