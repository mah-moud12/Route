using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Sorting
{
    class Sorting_TypeSolve
    {
        public static bool SordedAsc(int a,int b) => a > b;
        public static bool SordedDesc(int a,int b) => a < b;
        public static bool SordedAsc(string a,string b) => a?.Length > b?.Length;
        public static bool SordedDesc(string a,string b) => a?.Length < b?.Length;
    }
}
