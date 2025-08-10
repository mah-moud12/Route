using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Overriding
{
    class TypeC:TypeB
    {
        public int C { get; set; }

        public TypeC(int a,int b,int c):base(a,b)
        {
            C = c;
        }

        new public void MyFun01()
        {
            Console.WriteLine("I am Grand Child");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"A = {A}   ,   B = {B}   ,   C = {C}");
        }

    }
}
