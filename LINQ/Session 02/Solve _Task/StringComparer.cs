using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve__Task
{
    class StringComparer : IEqualityComparer<string>
    {


        public bool Equals(string? x, string? y)
        {
            if (x == null) return false;
            if (y == null) return false;


            x = x.Trim();
            y = y.Trim();
            x = string.Join("", x.OrderBy(c => c));
            y = string.Join("", y.OrderBy(c => c));

            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            obj = obj.Trim();
            obj = string.Join("", obj.OrderBy(c => c));
            return obj.GetHashCode();
        }
    }
}
