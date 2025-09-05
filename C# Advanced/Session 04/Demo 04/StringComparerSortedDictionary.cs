using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class StringComparerSortedDictionary : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x is null && y is null) return 0;
            else if (x is null) return 1;
            else if (y is null) return -1;
            return y.CompareTo(x);
        }
    }
}
