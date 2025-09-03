using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Sorting
{
    public delegate Tout SortingType<in T1,in T2,out Tout>(T1 a, T2 b);
    static class Sorting_Algorithm<T>
    {
        // Delegate حلت مشكلة اني اكرر 
        public static void BubbleSort(T[] arr,SortingType<T,T,bool> sortingType)
        {
            if (arr?.Length > 0 && sortingType is not null) 
            {
                for (int i = 0; i < arr.Length; i++)
                    for (int j = 0; j < arr.Length-i-1; j++)
                        //if (arr[j] > arr[j+1])
                        if (sortingType(arr[j], arr[j+1]))
                            Swap(ref arr[j], ref arr[j + 1]);
            }
        }

        #region reapting
        // التكرار وحش ف انا مش هعمل كده 

        //public static void BubbleSortDesc(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //            for (int j = 0; j < arr.Length-i-1; j++)
        //                if (arr[j] < arr[j+1])
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //    }
        //} 
        #endregion 

        static void Swap(ref T A,ref T B)
        {
            T temp = A;
            A = B;
            B = temp;
        }
    }
}
