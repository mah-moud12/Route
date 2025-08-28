using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Q01
{
    class Range01<T> where T:IComparable<T>
    {
        public T Maximum { get; set; }
        public T Minimum { get; set; }
        public Range01(T minimum, T maximum)
        {
            Maximum = maximum;
            Minimum = minimum;
        }

        public bool IsInRange(T value)
        {
            if (value.CompareTo(Minimum) > 0 && value.CompareTo(Maximum) == -1)
                return true;
            else
                return false;
        }

        public int Length()
        {
            return (int)((dynamic)Maximum - (dynamic)Minimum)-1;
        }
    }
}
