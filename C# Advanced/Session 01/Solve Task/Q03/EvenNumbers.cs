using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Q03
{
    static class EvenNumbers
    {
        public static List<int> ListOfEvenNumbers(List<int> values)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < values.Count; i++)
                if (values[i] % 2 == 0)
                    evenNumbers.Add(values[i]);

            return evenNumbers;
        }
    }
}
