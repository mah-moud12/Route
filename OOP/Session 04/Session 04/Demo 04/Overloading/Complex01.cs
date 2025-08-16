using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Overloading
{
    class Complex01
    {
        #region Properties 
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Constructor
        public Complex01(int Real, int Img)
        {
            this.Real = Real;
            this.Img = Img;
        }
        public Complex01()
        {
            
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Real = {Real} , Img = {Img}i";
        }
        #endregion

        #region Operator Overloading
        
        #region Binary Overloading
        public static Complex01 operator +(Complex01 C1, Complex01 C2)
        {
            //Complex01 C3 = new Complex01();
            //C3.Real = C1.Real + C2.Real;
            //C3.Img = C1.Img + C2.Img;
            //return C3;
            //--------------------------------------------
            //anathor way using object initializer
            //Complex01 C3 = new Complex01
            //{
            //    Real = C1.Real + C2.Real,
            //    Img = C1.Img + C2.Img
            //};
            //return C3;
            //--------------------------------------------
            //anathor way using object initializer
            return new Complex01
            {
                Real = (C1?.Real ?? 0) + (C2?.Real ?? 0),
                Img = (C1?.Img ?? 0) + (C2?.Img ?? 00)
            };
        }
        #endregion

        #region Unary Overloading
        public static Complex01 operator++(Complex01 C1)
        {
            return new Complex01
            {
                Real = (C1?.Real ?? 0) + 1,
                Img = C1?.Img ?? 0
            };
        }
        #endregion

        #region Relational Operator 

        public static bool operator >(Complex01 C1,Complex01 C2)
        {
            if (C1.Real == C2.Real)
                return C1.Img > C2.Img;
            else
                return C1.Real > C2.Real;
        } 
        public static bool operator <(Complex01 C1,Complex01 C2)
        {
            if (C1.Real == C2.Real)
                return C1.Img < C2.Img;
            else
                return C1.Real < C2.Real;
        }
        public static bool operator ==(Complex01 C1,Complex01 C2)
        {
                return C1.Real == C2.Real;
        }
        public static bool operator !=(Complex01 C1, Complex01 C2)
        {
                return C1.Real != C2.Real;
        }
        
        //logic
        public static bool operator true(Complex01 C1)
        {
            return C1.Real >0;
        }
        public static bool operator false (Complex01 C1)
        {
            return C1.Real < 0 && C1.Img<0;
        }
        #endregion

        #region Casting Overloading 

        public static /*No Return type*/ explicit operator int(Complex01 C1)
        {
            return C1?.Real ?? 0;
        }      
        public static /*No Return type*/ implicit operator string(Complex01 C1)
        {
            return C1?.ToString()??string.Empty;
        }

        #endregion

        #endregion


    }
}
