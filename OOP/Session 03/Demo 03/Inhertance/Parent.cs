using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Inhertance
{
    class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion

        #region Method

        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X = {X}  ,  Y = {Y}";
        }

        public static void myFun()
        {
            Console.WriteLine("I am Parent.");
        }

        #endregion


    }
}
