using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Overriding
{
    class TypeA
    {
        #region Property
        public int A { get; set; }
        #endregion

        #region Constructor 
        public TypeA(int a)
        {
            A = a;
        }
        #endregion

        #region Method 
        public virtual void MyFun01()
        {
            Console.WriteLine("I am Base");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"A = {A}");
        }
        #endregion

    }
}
