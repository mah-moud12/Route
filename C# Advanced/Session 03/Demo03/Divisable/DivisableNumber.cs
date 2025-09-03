using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Divisable
{
    public delegate T2 TypeDivisable<in T1,out T2>(T1 num);
    static class DivisableNumber<T>
    {

        public static List<T> GetDivisableNumber(T[] arr,Func<T,bool> typeDivisable)
        {
            List<T> oddNums = new List<T>();
            if (arr?.Length > 0 && typeDivisable is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    //if (arr[i] % 2 == 1)
                    if (typeDivisable.Invoke(arr[i]))
                    {
                        oddNums.Add(arr[i]);
                    }
                }
            }

            return oddNums;
        }

        #region reapting
        // التكرار وحش وانا مش هعمل كده 
        //public static List<int> GetEvenNumber(int[] arr)
        //{
        //    List<int> evenNums = new List<int>();
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] % 2 == 0)
        //            {
        //                evenNums.Add(arr[i]);
        //            }
        //        }
        //    }

        //    return evenNums;
        //} 
        #endregion

    }
}
