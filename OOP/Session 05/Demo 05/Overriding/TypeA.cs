using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Overriding
{
    class TypeA
    {
        public int A { get; set; }


        #region Constructor
        public TypeA(int _A)
        {
            A = _A;
        }
        #endregion

        #region Method 
        public void MyFun01()
        {
            Console.WriteLine("I am Base");
        }

        virtual public void MyFun02()
        {
            Console.WriteLine($"A = {A}");
        }
        #endregion



    }
}
