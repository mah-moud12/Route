using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface
{
    class TypeB:ITypeA,IType01
    {
        public int Current { get; set; }
        public int X { get; set ; }

        public void GetNext()
        {
            Current += 4;
        }

        //IType01
        public void MyFun01()
        {
            Console.WriteLine("Multible Inhertance"); ;
        }
    }
}
