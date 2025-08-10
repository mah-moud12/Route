using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Overriding
{
    class TypeB:TypeA
    {
        public int B { get; set; }


        #region Constructor 
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        #endregion

        #region Method
        public new void MyFun01()
        {
            Console.WriteLine("I am Drived.");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"A = {A}   ,   B = {B}");
        }
        public void print()
        {
            Console.WriteLine($"Only B = {B}");
        }

        #endregion

    }
}
