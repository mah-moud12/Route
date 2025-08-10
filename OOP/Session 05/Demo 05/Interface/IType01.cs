using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface
{
    interface IType01
    {
        // 1. Signature For Property
        public int X { get; set; }

        // 2. Signature For Method
        public void MyFun01();  

        // 3. Default Implemented Method "C# 8.0"
        public  void Print()
        {
            Console.WriteLine("Hello, Hoda");
        }
    }
}
