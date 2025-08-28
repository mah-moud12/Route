using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    // Generic Method
    // بعملها كده لما اكون عاوز استخدم Genaric على كدا method فبدل لما اقعد اكتبها على اكتر من فانكشن بحطها على class وخلاص وهتشتغل على الميثود عادي 

    static class Helper <T> where T : IEquatable<T>,IComparable<T>
    {
        #region Swap

        #region Overload Method
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref decimal x, ref decimal y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region Object
        // ده الحل اللي كان قبل ما Generic تظهر وكان وحش لانه بيضعف performance 
        //public static void Swap(ref object x, ref object y)
        //{
        //    object temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region Generic Method
        // هنا بدل ما استخدم ال overload وكرر وهما اصلا نفس ال behavior 
        // هنا انا اختصرت واستخدمت function واحده تعمل الكلام ده واستخدمت ال Generic 
        public static void Swap/*<T>*/(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void print/*<T>*/(T x, T y)
        {
            Console.WriteLine("I am Helper Class.");
        }
        #endregion

        #endregion

        #region LinearSearch

        public static int LinearSearch(T[] arr, T value) { 
            
            // && Short =>  دي المناسبة اني استخدمها لان انا مش عاوزه يروح لل length 
            // & long => مش مناسبة لانه حته لو الاولى غلط هيروح على التانية وكده هيضرب exception 

            if(/*arr is not null && */arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // هنا انا اول لما بعتت للفانكشن دي parameter generic ضرب error لإن ال == مش مدعومه في اني اساوي اي داتا تايب ببعض لان ممكن الداتا دي تكون user Define مثلا من struct or class ف انا مش ضامن 
                    //if (arr[i] == value) // بعد لما اعمل  operator overload برضو مش هتشتغل لان هو مش ضامن باقيه user define زي الكلاس مثلا مطبقين ال overloding ولا لا فلازم استخدم Equals 
                    if ( arr[i]?.Equals(value)??false) // هنا بيروح على Equals بتاعت object اللي انا عاملها Override فعلشان اخليها تروح على حاجه معينه مثلا زي Employee لازم استخدم where     
                        return i;
                }
            }
            return -1;
        } 
        public static int LinearSearch(T[] arr, T value,IEqualityComparer<T> comparer) { 
            
            // && Short =>  دي المناسبة اني استخدمها لان انا مش عاوزه يروح لل length 
            // & long => مش مناسبة لانه حته لو الاولى غلط هيروح على التانية وكده هيضرب exception 

            if(/*arr is not null && */arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // هنا انا اول لما بعتت للفانكشن دي parameter generic ضرب error لإن ال == مش مدعومه في اني اساوي اي داتا تايب ببعض لان ممكن الداتا دي تكون user Define مثلا من struct or class ف انا مش ضامن 
                    //if (arr[i] == value) // بعد لما اعمل  operator overload برضو مش هتشتغل لان هو مش ضامن باقيه user define زي الكلاس مثلا مطبقين ال overloding ولا لا فلازم استخدم Equals 
                    if (comparer.Equals(arr[i],value)) // هنا بيروح على Equals بتاعت object اللي انا عاملها Override فعلشان اخليها تروح على حاجه معينه مثلا زي Employee لازم استخدم where     
                        return i;
                }
            }
            return -1;
        }


        #endregion

        #region Bubble Sort
        public static void BubbleSort(T[] arr)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length-i-1; j++)
                    {
                        //if (arr[j] > arr[j + 1])
                        if (arr[j].CompareTo(arr[j+1])>0)
                        {
                            Helper<T>.Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
         public static void BubbleSort(T[] arr,IComparer<T> comparer)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length-i-1; j++)
                    {
                        //if (arr[j] > arr[j + 1])
                        //if (arr[j].CompareTo(arr[j+1])>0)
                        if (comparer.Compare(arr[j], arr[j+1])>0)
                        {
                            Helper<T>.Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }

        #endregion
    } 
}
