using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Overloading
{
    class Complex
    {
        #region Properties 
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Constructor
        public Complex(int Real,int Img)
        {
            this.Real = Real;
            this.Img = Img;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Real = {Real} , Img = {Img}";
        }
        #endregion


    }
}
