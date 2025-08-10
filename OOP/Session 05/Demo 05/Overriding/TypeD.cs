using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Overriding
{
    class TypeD:TypeC
    {
        public int D { get; set; }

        public TypeD(int a, int b, int c,int D):base(a,b,c)
        {
            this.D = D;
        }

        new public void MyFun01()
        {
            Console.WriteLine("I am Child [Grand Child]");
        }

        public virtual new void MyFun02()
        {
            Console.WriteLine($"A = {A}   ,   B = {B}   ,   C = {C}   ,   D = {D}");
        }
    }
}
