using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02
{
    struct Point
    {
        #region Attribute
        public int X;
        public int Y;
        #endregion

        #region Constructor
        //Constructor:
        //    It is a special function for two reasons:
        //         1 -> Name as Struct
        //         2 -> Has no return type

        //--------------------------
        //Constructor C# 9 [.net 05] : Structs cannot have an explicit parameterless constructor before C#10
        //compiler provides a default constructor:
        //      يعني انت لو استخدمت .net 5 مكنش ينفع انا اللي اعملة كان بيتعمل لوحده اول لما بكتب new
        //      ده اسمه parameterless constructor:
        //            => سواء عملته او معملتوش هو بيكون موجود اصلا
        public Point() 
        {
            X = default;
            Y = default;
        }

        public Point(int _X,int _Y)
        {
            X = _X;
            Y = _Y;
        }
        //Constructor C# 11 [.net 07] : User defined constructor can skip attribute of struct without initialization:
        //    دي بيقولك ان انت في .net 7.0 بقى عادي انك تعمل skip ل variable عادي قبل .net 7.0 مكنش ينفع اعمل كده هيطلعلي error
        public Point(int _X)
        {
            X = _X;
        }

        #endregion

        #region Method
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        #endregion

    }
}
