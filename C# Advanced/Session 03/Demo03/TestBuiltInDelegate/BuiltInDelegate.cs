using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Demo03.TestBuiltInDelegate
{
    static class BuiltInDelegate
    {
        public static bool CheckPositive(int num) => num > 0;
        public static string Casting(int num) => num.ToString();
        public static void Print() =>Console.WriteLine("Hello ya Ray2");
        public static void Print(string name) =>Console.WriteLine($"Hello ya {name} ya Ray2");
    }
}
