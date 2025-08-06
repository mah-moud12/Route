using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Overriding
{
    class TypeB:TypeA
    {
        #region Properties
        public int B { get; set; }
        #endregion

        #region Constructor
        public TypeB(int a,int b):base(a)
        {
            B = b;
        }
        #endregion

        #region Method 
        //using keyword "overriding" inhirt member TypeA.MyFun01()
        //TypeA.MyFun01() must be marked as virtual and non-private
        //run time
        public override void MyFun01()
        {
            Console.WriteLine("I am Drived");
        }
        //using keyword "new" to hiding inherit member TypeA.MyFun01()
        //compile time
        public new void MyFun02()
        {
            Console.WriteLine($"A = {A}  ,  B = {B}");
        }
        #endregion
    }
}
