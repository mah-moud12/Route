using Demo03.Divisable;
using Demo03.Sorting;
using Demo03.TestBuiltInDelegate;
using System.Runtime.CompilerServices;

namespace Demo03
{
    //0. Defining a Delegate
    public delegate int StringFuncCount(string s);
    // New Delegate [Class]
    // Refer From Delegate Can Refer To Function Or More [Pointer To Function]
    // Function Can Be Static Function [Class Member Function]
    // Function Can Be Non-Static Function [Object Member Function]
    // This Function Must be With Same Signature Of Delegate 
    // Regardless Function Nameing [ Method Name - Parameter Name ] 
    // Regardless Access Modifier
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 01
            ////int v = StringFunctions.GetCountOfUpperCase; // Invalid

            //// 1. Declare Reference From Delegate
            //StringFuncCount count;

            //// 2. Initialize Reference From Delegate[Pointer To Function]
            ////count = new StringFuncCount(StringFunctions.GetCountOfUpperCase);

            ////another defination
            //count = StringFunctions.GetCountOfUpperCase;

            //count += StringFunctions.GetCountOfLowerCase; // ( count refer => GetCountOfLowerCase and GetCountOfUpperCase )

            //count -= StringFunctions.GetCountOfLowerCase; // ( count refer => GetCountOfUpperCase )

            ////count -= StringFunctions.GetCountOfUpperCase; // ( count refer => Null) => NullReferenceException

            //// 3. Use Delegate Reference [Call Method] 
            ////int countUpper = count?.Invoke("MahmOud") ?? 0;

            //// another Call
            //int countUpper = count("MahmOud");
            //Console.WriteLine(countUpper);
            #endregion

            #region Example 02

            #region regular
            //int[] arr = { 1, 2, 6, 7, 8, 3, 9, 5 };
            ////SortingType sortingType01 =null; // NullreferenceException
            //SortingType<int,int,bool> sortingType = Sorting_TypeSolve.SordedDesc;
            //Sorting_Algorithm<int>.BubbleSort(arr/*,Sorting_TypeSolve.LessThan*/, sortingType);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generic 
            //int[] arr = { 1, 2, 6, 7, 8, 3, 9, 5 };
            ////SortingType sortingType01 =null; // NullreferenceException
            //SortingType<int, int, bool> sortingType = Sorting_TypeSolve.SordedAsc;
            //Sorting_Algorithm<int>.BubbleSort(arr/*,Sorting_TypeSolve.LessThan*/, sortingType);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////
            //string[] arrStr = new string[] { "Mahmoud", "Mohamed", "Yousef", "MOstafaaaa" };
            ////SortingType<string> sortingType1 = Sorting_TypeSolve.SordedAsc;
            //SortingType<string, string, bool> sortingType1 = Sorting_TypeSolve.SordedDesc;

            //Sorting_Algorithm<string>.BubbleSort(arrStr, sortingType1);

            //foreach (var item in arrStr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Example 03
            //int[] arr = Enumerable.Range(1, 100).ToArray();

            //TypeDivisable typeDivisable = OddEvenDivisable.DivisableOdd;
            //TypeDivisable<int, bool> typeDivisable = FilterElement.DivisableEven;
            //Func<int, bool> func1 = FilterElement.DivisableEven;
            //List<int> checkElement = DivisableNumber<int>.GetDivisableNumber(arr, func1);
            //foreach (var item in checkElement)
            //{
            //    Console.Write(item + " ");
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //string[] arr = { "Mahmoud", "Sara", "Amr", "Ali", "Yousef" };
            //List<string> elem = DivisableNumber<string>.GetDivisableNumber(arr, FilterElement.GetLengthMoreThanFour);
            ////List<string> elem = DivisableNumber<string>.GetDivisableNumber(arr, FilterElement.GetLengthLessThanFour);

            //Func<string, bool> func1 = FilterElement.GetLengthMoreThanFour;
            ////List<string> elem = DivisableNumber<string>.GetDivisableNumber(arr, func1);

            //foreach (var item in elem)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Use Built-In-Delegate

            #region Predicate
            // بتاخد parameter واح بس وبترجع bool
            //Predicate<int> predicate = BuiltInDelegate.CheckPositive;
            //bool flag = predicate(10);
            //Console.WriteLine(flag);

            // another way
            //Func<int, bool> fun = BuiltInDelegate.CheckPositive;
            //bool flag = fun.Invoke(10);
            //Console.WriteLine(flag); 
            #endregion

            #region Func
            // بتاخد 0-16 parameter ولازم return لو معملتش return غلط 
            //Func<int, string> func = BuiltInDelegate.Casting;
            //string res = func(10);
            //Console.WriteLine(res);

            // Invalid
            //Func<string, void> func1 = BuiltInDelegate.Print; // علشان Void وال Func لازم اعمل Return 
            #endregion

            #region Action Genaric and non-Genaric
            //// non-Generic
            //Action action = BuiltInDelegate.Print;
            //action();

            //Action<string> action1 = BuiltInDelegate.Print;
            //action1("Mahmoud");
            #endregion

            #endregion

            #region Anonymous Method
            // بعملها لو مش هستخدم الفانكشن في حته تانيه [C# 2.0 [2005]]
            // بتكون من غير اسم 

            //Predicate<int> predicate = delegate (int num) { return num > 0; };
            //bool flag = predicate(10);
            //Console.WriteLine(flag);

            // another way
            //Func<int, bool> fun = delegate (int num) { return num > 0; };
            //bool flag02 = fun.Invoke(10);
            //Console.WriteLine(flag02);
            //***********************************************************************************

            //Func<int, string> func = delegate (int num){ return num.ToString(); };
            //string res = func(10);
            //Console.WriteLine(res);

            // Invalid
            //Func<string, void> func1 = BuiltInDelegate.Print; // علشان Void وال Func لازم اعمل Return 

            //***********************************************************************************
            // non-Generic
            //Action action = delegate () { Console.WriteLine("Hello Route"); };
            //action();

            ////// Generic
            //Action<string> action1 = delegate (string name) { Console.WriteLine($"Hello {name}"); };
            //action1("Mahmoud");
            #endregion

            #region Lambda Expressions 
            //// دي اتعملت  تطوير ل Anonymous Method 

            //Predicate<int> predicate = (int num) => num > 0;
            //bool flag = predicate(10);
            //Console.WriteLine(flag);

            ////another way
            //Func<int, bool> fun = num => num > 0;
            //bool flag02 = fun.Invoke(10);
            //Console.WriteLine(flag02);
            ////***********************************************************************************

            //Func<int, string> func = num  => num.ToString();
            //string res = func(10);
            //Console.WriteLine(res);

            ////Invalid
            ////Func<string, void> func1 = BuiltInDelegate.Print; // علشان Void وال Func لازم اعمل Return 

            ////***********************************************************************************
            ////non - Generic
            //Action action =  () => Console.WriteLine("Hello Route"); 
            //action();

            ////// Generic
            //Action<string> action1 = name=>Console.WriteLine($"Hello {name}"); 
            //action1("Mahmoud");



            #endregion

            #region List<T>Methods Take Function As Parameter 
            //List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 4, 2, 5 });

            //bool flag = list.Exists(Check);
            //Console.WriteLine(flag);
            //Console.WriteLine("====================");
            ////***************************************************************************

            ////int elem = list.Find(num => num == 10); // لو مش لاقاه هرجع صفر 
            ////int elem = list.Find(num => num % 2 == 0);
            //int elem = list.FindLast(num => num % 2 == 0); // هيبحث من الاخر 

            ////***************************************************************************

            //int pos = list.FindIndex(num => num == 2);
            ////int pos = list.FindLastIndex(num => num == 2);
            //Console.WriteLine(pos);
            //Console.WriteLine("====================");
            //List<int> nums = list.FindAll(num => num > 2);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            ////***************************************************************************
            //list.ForEach(num => Console.WriteLine(++num));

            //bool flag01 = list.TrueForAll(num => num > 1); // false لان مش كل العناصر متطابقة مع الشرط اللي انا حاطه 
            //Console.WriteLine(flag01);
            ////***************************************************************************
            //list.RemoveAll(num => num % 2 == 0);
            //list.ForEach(item => Console.WriteLine(item));
            #endregion

            #region Functional Programming Paradigm 

            //Predicate<int> predicate = FPP.predicate();
            //bool flag = predicate(18);
            //flag = predicate.Invoke(16);

            //flag = FPP.predicate().Invoke(14);

            //flag = FPP.predicate()(12);

            //Console.WriteLine(flag);
            //****************************************************************
            //Action action = FPP.Print();
            //action();
            //action.Invoke();
            //Console.WriteLine();
            //FPP.Print(); // Nothig
            //Console.WriteLine();
            //FPP.Print()();
            //FPP.Print().Invoke();
            //****************************************************************
            //Func<int, int> func = FPP.Func();
            //int num = func(-16);
            //Console.WriteLine(num);
            #endregion
        }
        static bool Check(int num) => num == 10;
    }
}
