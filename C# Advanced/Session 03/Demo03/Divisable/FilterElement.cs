using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Divisable
{
    static class FilterElement
    {   
        public static bool DivisableEven(int num) => num % 2 == 0;
        public static bool DivisableOdd(int num) => num % 2 == 1;
        public static bool DivisableBy7(int num) => num % 7 == 0;
        public static bool DivisableBy3(int num) => num % 3 == 0;
        public static bool GetLengthMoreThanFour(string num) => num?.Length > 4;
        public static bool GetLengthLessThanFour(string num) => num?.Length <= 4;
    }
}
