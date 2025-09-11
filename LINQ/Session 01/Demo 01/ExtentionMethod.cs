using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    static class ExtentionMethod
    {
        //  علشان اعمل Extention Method لازم الكلاس يكون static والفانكشن متكونش Generic 
        public static int Reverse(this int num)
        {
            int reversedNumber = 0,reminder;
            while (num != 0)
            {
                reminder = num % 10;
                reversedNumber = reversedNumber * 10 + reminder;
                num /= 10;
            }
            return reversedNumber;
        }
        
        // بس ده كده تكرار ودا وحش 
        //public static long Reverse(this long num)
        //{
        //    long reversedNumber = 0,reminder;
        //    while (num != 0)
        //    {
        //        reminder = num % 10;
        //        reversedNumber = reversedNumber * 10 + reminder;
        //        num /= 10;
        //    }
        //    return reversedNumber;
        //}
    }
}
