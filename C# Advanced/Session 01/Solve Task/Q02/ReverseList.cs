using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Q02
{
    static class ReverseList<T>
    {
        public static void Swap(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void RverseArrayList(List<T> values)
        {
            for (int i = 0; i < values.Count/2; i++)
            {
                T a = values[i];
                T b = values[values.Count - i - 1];
                ReverseList<T>.Swap(ref a, ref b);
                values[i] = a;
                values[values.Count - i - 1] = b;
            }
        }
    }
}
