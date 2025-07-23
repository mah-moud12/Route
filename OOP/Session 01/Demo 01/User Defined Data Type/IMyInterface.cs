using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.User_Defined_Data_Type
{
    interface IMyInterface//default internal
    {
        #region  What You Can Write Inside ?

        // 1. Signature For Property => C# 7.0
        int Id { get; set; } //default Public 

        //2. Signature For Method => C# 7.0
        void print();

        //3. Default Implemented Method => C# 8.0 Feature .Net Core 3.1 [2019] 

        void Display()
        {
            Console.WriteLine("Mahmoud");
        }

        //ينفع يستخدم كل access modifier ماعدا Private 
        //private => ممكن تستخدمها في حالة واحده في  Default Implemented Method




        #endregion

    }
}
