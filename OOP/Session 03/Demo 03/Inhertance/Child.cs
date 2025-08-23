using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Inhertance
{
    // By Default Constructor of child بيعمل Constructor Chaining مع  empty parameterless Constructor اللي موجود جوه اال parent

    class Child :Parent 
    {
        #region properties 
        public int Z { get; set; }
        #endregion

        #region Constructor 
        public Child(int x , int y,int z):base(x,y)
        {
            Z = z;
        }
        #endregion

        #region Method 
        public override string ToString() // ال parent هو اللي بيسمح مين اللي هيتورث ومين اللي مش هيتورس يعني لو هيورث  يبقى عن طريق virtual
        {
            return $"X = {X} , Y = {Y} , Z = {Z}";
        }

        //public override int Product() { } // Error لازم اروح لل parent اخليه يسمحلي انها تتورث عن طريق virtual

        public override int Product()
        {
            return base.Product() * Z;
        }

        public new void myFun()
        {
            Console.WriteLine("I am Child");
        }


        #endregion

    }
}
