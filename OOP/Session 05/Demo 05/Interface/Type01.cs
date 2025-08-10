using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface
{
    class Type01 : IType01
    {
        public int X { get; set; }

        public void MyFun01()
        {
            Console.WriteLine("Implement from class");
        }
     
    }
}
