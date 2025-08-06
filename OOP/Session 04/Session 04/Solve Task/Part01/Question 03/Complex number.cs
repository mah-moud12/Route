using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class Complex_number
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; } 
        #endregion


        public static Complex_number operator+(Complex_number C1,Complex_number C2)
        {
            return new Complex_number
            {
                Real = C1.Real + C2.Real,
                Img = C1.Img + C2.Img
            };
        }
        public static Complex_number operator -(Complex_number C1, Complex_number C2)
        {
            return new Complex_number
            {
                Real = C1.Real - C2.Real,
                Img = C1.Img - C2.Img
            };
        }


        public override string ToString()
        {
            return $"Real = {Real}   ,   Img = {Img}i";
        }


    }
}
