using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    static class RemoveOddNumber
    {
        public static List<int> RemoveOdd(int[] arr)
        {
            List<int> values = new List<int>();
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 == 0)
                        values.Add(arr[i]);
            }
            return values;
        }

    }
}
