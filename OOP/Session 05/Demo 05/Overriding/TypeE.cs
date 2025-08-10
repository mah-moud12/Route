using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Overriding
{
    class TypeE:TypeD
    {
        public int E { get; set; }

        public TypeE(int a, int b, int c, int D,int E):base(a,b,c,D)
        {
            this.E = E;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Child [Grand Child]");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"A = {A}   ,   B = {B}   ,   C = {C}   ,   D = {D}   ,   E = {E}");
        }
     
    }
}
