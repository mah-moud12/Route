using static Data_01.ListGenerator;
using Data_01.Data;
using System.Collections.Generic;
using System.Linq;

namespace Solve__Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = File.ReadAllLines("C:\\Users\\Mr Ali\\Music\\Route\\LINQ\\Session 02\\Solve _Task\\dictionary_english.txt");
            #region LINQ - Aggregate Operators

            #region 01
            //var countOfProduct = from p in Products
            //                     where p.UnitsInStock > 0
            //                     group p by p.Category
            //                         into category
            //                     select new
            //                     {
            //                         CategoryName = category.Key,
            //                         Total = category.Sum(p => p.UnitsInStock)
            //                     };

            //countOfProduct = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Select(c => new
            //{
            //    CategoryName = c.Key,
            //    Total = c.Sum(p => p.UnitsInStock)
            //});

            //foreach (var c in countOfProduct)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region 02
            //var cheapest = from p in Products
            //               group p by p.Category
            //                    into c
            //               select new
            //               {
            //                   CategoryName = c.Key,
            //                   cheapest = (c.OrderBy(ss => ss.UnitPrice).FirstOrDefault())?.UnitPrice
            //               };

            //cheapest = Products.GroupBy(p => p.Category).Select(c => new
            //{

            //    CategoryName = c.Key,
            //    cheapest = c?.Min(c => c.UnitPrice)

            //});



            ////Console.WriteLine(cheapest[0]);
            //foreach (var item in cheapest)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 03
            //var result = from p in Products
            //             group p by p.Category
            //                into Cat
            //             let Cheapest = Cat.OrderBy(p => p.UnitPrice).FirstOrDefault()
            //             select new { CategoryName = Cat.Key, CheapestProduct = Cheapest };

            //result = from p in Products
            //         group p by p.Category
            //             into Cat
            //         let Cheapest = Cat.Min(c => c.UnitPrice)
            //         select new
            //         {
            //             CategoryName = Cat.Key,
            //             CheapestProduct = Cat.Where(c => c.UnitPrice == Cheapest).FirstOrDefault()
            //         };

            //result = Products.GroupBy(p => p.Category).Select(Cat => new
            //{
            //    CategoryName = Cat.Key,
            //    CheapestProduct = Cat.OrderBy(p => p.UnitPrice).FirstOrDefault()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 04
            //var result = from p in Products
            //             group p by p.Category
            //                 into Cat
            //             let Cheapest = Cat.Max(p => p.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Cat.Key,
            //                 Cat.Where(c => c.UnitPrice == Cheapest).FirstOrDefault()?.ProductName,
            //                 CheapestPrice = Cat.Where(c => c.UnitPrice == Cheapest).FirstOrDefault()?.UnitPrice
            //             };
            //result = Products.GroupBy(p => p.Category).Select(Cat => new
            //{
            //    CategoryName = Cat.Key,
            //    Cat.OrderBy(c => c.UnitPrice).FirstOrDefault()?.ProductName,
            //    CheapestPrice = Cat.OrderByDescending(c => c.UnitPrice).FirstOrDefault()?.UnitPrice
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 05
            //var result = from p in Products
            //             group p by p.Category
            //             into Cat
            //             let Cheapest = Cat.Max(cc => cc.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Cat.Key,
            //                 Prod=Cat.Where(c => Cheapest == c.UnitPrice).FirstOrDefault()
            //             };
            //result = Products.GroupBy(p => p.Category).Select(Cat => new
            //{
            //    CategoryName = Cat.Key,
            //    //Prod = Cat.Where(c => Cat.Max(cc => cc.UnitPrice) == c.UnitPrice).FirstOrDefault()
            //    Prod = Cat.OrderByDescending(c => c.UnitPrice).FirstOrDefault()

            //});
            //foreach (var item in result)
            //    Console.WriteLine(item); 
            #endregion

            #region 06
            //var result = from p in Products
            //             group p by p.Category
            //             into Cat
            //             select new
            //             {
            //                 CategoryName = Cat.Key,
            //                 AvgProduct = Cat.Average(c => c.UnitPrice)
            //             };

            //result = Products.GroupBy(p => p.Category).Select(c => new
            //{
            //    CategoryName=c.Key,
            //    AvgProduct=c.Average(p=>p.UnitPrice)
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item); 
            #endregion
            #endregion

            #region LINQ - Set Operators

            #region 01
            ////HashSet<string> result = Products.Select(p => p.Category).ToHashSet()!;

            //// another way
            //var result = Products.Select(p => p.Category).Distinct();

            //foreach (var item in result)
            //    Console.WriteLine(item); 
            #endregion

            #region 02
            //var result = Products.Select(p => p?.ProductName?[0]).Union(Customers.Select(c => c?.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 03
            //var result = (from p in Products
            //              select p.ProductName?[0]).Intersect(Customers.Select(c => c?.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 04
            //List<char> result = Products.Select(p => p.ProductName![0]).Except(Customers.Select(c => c.CustomerName[0])).ToList();

            //foreach (var item in result)
            //    Console.WriteLine(item); 
            #endregion

            #region 05
            //var result = (from p in Products
            //              where p.ProductName?.Length >= 3
            //              select p?.ProductName?.Substring(p.ProductName.Length - 3, 3))
            //                 .Concat(Customers.Where(c => c.CustomerName.Length >= 3).Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3, 3)));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 01
            //var result = Customers.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 02
            //var result = Customers.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, i) => n > i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 04
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 05
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, i) => n > i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers

            #region 01
            //string[] result = word.Where(w => w.Contains("ei")).ToArray();
            //if (result.Length > 0)
            //    Console.WriteLine("Found");
            //else
            //    Console.WriteLine("Not Found");

            //// another way
            //bool result02 = word.Any(w => w.Contains("ei"));

            //if (result02)
            //    Console.WriteLine("Found");
            //else
            //    Console.WriteLine("Not Found"); 
            #endregion

            #region 02

            //var result = Products.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0)).Select(c => new
            //{
            //    CategoryName = c.Key,
            //    prod = c.Select(p => p),


            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //    foreach(var p in item.prod)
            //        Console.WriteLine($"     {p}");
            //}
            #endregion

            #region 03
            //var result = Products.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0)).Select(c => new
            //{
            //    CategoryName = c.Key,
            //    prod = c.Select(p => p),
            //});

            //result = (from p in Products
            //          group p by p.Category).Where(c => c.All(p => p.UnitsInStock > 0)).Select(c => new
            //          {
            //              CategoryName = c.Key,
            //              prod = c.Select(p => p),
            //          });


            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.CategoryName);
            //    foreach (var p in Category.prod)
            //    {
            //        Console.WriteLine($"     {p}");
            //    }
            //}
            #endregion
            #endregion

            #region LINQ – Grouping Operators


            #region 01
            //List<int> numbers = new List<int> { 0, 8, 9, 14, 15, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(num1 => num1 % 5).OrderBy(g=>g.Key);

            //foreach (var remin in result)
            //{
            //    Console.WriteLine(remin.Key);
            //    foreach (var item in remin)
            //    {
            //        Console.WriteLine($"   {item}");
            //    }
            //}
            #endregion

            #region 02
            //var result = word.GroupBy(w => w[0]);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var Vals in group)
            //    {
            //        Console.WriteLine($"  {Vals}");
            //    }
            //} 
            #endregion

            #region 03
            string[] Arr = { "from", "salt", "earn", " last", "near", "romf" };


            var res = Arr.GroupBy(a => a, new StringComparer());
            foreach (var item in res)
            {
                Console.WriteLine(item.Key);
                foreach (var e in item)
                {
                    Console.WriteLine(e);
                }
            }
            #endregion

            #endregion
        }
    }
}
