using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Demo03
{
    class FPP
    {


        public static Action Print() => () => Console.WriteLine("Hello , World");

        public static Action<string> PrintG() => name => Console.WriteLine($"Hello , {name}");

        public static Func<int, int> Func() => num => num > 0 ? num : -1;

        //public static Predicate<int> predicate() => delegate (int num) { return num > 0 ? true :false; };
        public static Predicate<int> predicate() => num => num > 0 ? true : false;
    }
}
