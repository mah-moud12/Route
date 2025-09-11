using Data01;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Intrinsics.Arm;
using System.Security.AccessControl;
using System.Threading;
using System.Xml.Linq;
using static Data01.ListGeneratorHelpers;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Solve_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 01
            //var OutOfStock = Products.Where(p=>p.UnitsInStock==0);
            //foreach (var item in OutOfStock) Console.WriteLine(item);
            #endregion

            #region 02
            //var InStock = Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var item in InStock) Console.WriteLine(item);
            #endregion

            #region 03
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Short01 = Arr.Where((shorter, i) => shorter.Length < i);

            //// another way
            //var Short02 = from shorter in Arr.Select((shorter1, i) => new { digit = shorter1, index = i })
            //              where shorter.digit.Length < shorter.index
            //              select shorter.index;

            //foreach (var item in Short02)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ - Element Operators

            #region 01
            //var firstOutOfStock = Products.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutOfStock);
            #endregion

            #region 02
            //var greaterThan = Products.Where(p => p.UnitPrice > 1000m).FirstOrDefault();
            //Console.WriteLine(greaterThan);
            #endregion

            #region 03

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10 };
            //List<int> SecGreater01 = new List<int>();
            //for (int i = 0; i < Arr.Length; i++)
            //    if (Arr[i] > 5)
            //        SecGreater01.Add(Arr[i]);
            //SecGreater01.Sort();
            //Console.WriteLine(SecGreater01[SecGreater01.Count-2]);
            ///*******************************************************/
            ////another way

            //int SecGreater02 = Arr.Where(p => p > 5).OrderByDescending(p => p).ElementAt(1);
            //Console.WriteLine(SecGreater02);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators

            #region 01
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var countOddNumber = Arr.Count(p => p % 2 != 0);
            //Console.WriteLine(countOddNumber);
            #endregion

            #region 02
            //var list = Customers.Select(c => new
            //{
            //    c.CustomerName,
            //    countOrder = c.Orders.Count()
            //});
            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 03
            //var list = Products.Select(p => new
            //{
            //    Category = p.Category,
            //    CountOfProduct = Products.Count(pro=>pro.Category == p.Category)
            //}).ToHashSet();

            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 04

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var list = Arr.Sum();
            //Console.WriteLine(list); 

            #endregion

            #region 05


            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 01
            //var sortProduct = Products.OrderBy(p => p.ProductName);
            //foreach (var item in sortProduct)
            //    Console.WriteLine(item);
            #endregion

            #region 02
            //string[] Arr = { "aPPLE", "apAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortString = Arr.OrderBy(a => a,new StringComparer());

            //foreach (var item in sortString)
            //    Console.WriteLine(item);
            #endregion

            #region 03
            //var list = Products.OrderByDescending(p=>p.UnitsInStock);
            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 04
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var list = Arr.OrderBy(a => a.Length).ThenBy(a => a);
            //foreach (var item in list)
            //Console.WriteLine(item);
            #endregion

            #region 05
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var list = Arr.OrderBy(a=>a.Length).ThenBy(a=>a,new StringComparer());

            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 06
            //var listProducts = Enumerable.OrderByDescending(Products,p=>p.Category).ThenByDescending(p=>p.UnitPrice);
            //foreach (var item in listProducts)
            //    Console.WriteLine(item);
            #endregion

            #region 07
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortByLengthAndAlpha = (from a in Arr
            //                           orderby a.Length
            //                           select a).ThenBy(a=>a,new StringComparerDescending());
            //foreach (var item in sortByLengthAndAlpha)
            //    Console.WriteLine(item);
            #endregion

            #region 08
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //Arr = Arr.Where(a => a[1] == 'i').Reverse().ToArray();

            //foreach (var item in Arr)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ – Transformation Operators

            #region 01
            //var list = Products.Select(p =>new { p.ProductName });
            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 02
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var list = words.Select(p => new { LowerCase = p.ToLower(), UpperCase = p.ToUpper() });
            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 03
            //var list = Products.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price = p.UnitPrice
            //});
            //foreach (var item in list)
            //    Console.WriteLine(item);

            #endregion

            #region 04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var list = Arr.Select((p, i) => new { num = p, flag = (p == i) });

            //foreach (var item in list)
            //    Console.WriteLine(item);

            #endregion

            #region 05
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var list = numbersA.SelectMany(a => numbersB,(a,b)=>new { a,b})
            //      .Where(pair => pair.a < pair.b);

            #region Notes
            //TSource → type of each element in the outer sequence(e.g., numbersA elements)
            //TCollection → type of each element in the inner collection returned by the collection selector(e.g., numbersB elements)
            //TResult → type of the final result produced by the result selector
            #endregion


            //list = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select new { a, b };

            //foreach (var item in list)
            //    Console.WriteLine(item);



            #endregion

            #region 06
            //var list = Customers.SelectMany(o => o.Orders).Where(o=>o.Total<500);
            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region 07

            //var list = Customers.SelectMany(c => c.Orders).Where(o => o.OrderDate>=new DateTime(1998,1,1));
            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion
            #endregion




        }
    }
}
