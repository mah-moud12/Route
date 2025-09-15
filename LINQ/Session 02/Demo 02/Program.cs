using Data_01.Data;
using System.Collections;
using System.Linq;
using static Data_01.ListGenerator;
namespace Demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting [Conversion] Operators - Immediate Execution

            #region ToList and ToArray
            //List<Product> Result = Products.Where(p => p.UnitsInStock == 0); // exception لان اللي راجع من نوع Ienumrable 
            //List<Product> Result = Products.Where(p => p.UnitsInStock == 0).ToList();
            //*************************************************************************************************************

            //Product[] Result= Products.Where(p => p.UnitsInStock == 0).ToArray();
            //************************************************************************************************************* 

            #endregion

            #region HashSet and Dictionary
            //HashSet<Product> Result = Products.Where(p => p.UnitsInStock == 0).ToHashSet();
            //*************************************************************************************************************

            //Dictionary<long,Product> Result= Products.Where(p => p.UnitsInStock == 0).ToDictionary(p=>p.ProductID);// كده انا اديتها ال key بس طب لي مش اديتها ال value لان هو اصلا اللي راجع product فمش لازم اديها بس عادي اديها value  بس انا مش هديها عادي

            //another example

            //Dictionary<long, string> Result = Products.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID,pp=>pp.ProductName);

            //************************************************************************************************************* 
            #endregion

            #region OfType
            //ArrayList array =new ArrayList{
            //    "Mahmoud",
            //    "Ali",
            //    1,2,4
            //};
            // var Result = array.OfType<string>(); // بحدد النوع اللي هيرجع 
            //foreach (var item in Result)
            //    Console.WriteLine(item);  
            #endregion

            #endregion

            #region Generation Operators - Deferred Execution

            //var Result = Enumerable.Range(1, 100); // 1 - 100
            //Result = Enumerable.Repeat(3, 40); // 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 3 .... 3
            //******************************************************************************

            //var Result = Enumerable.Empty<Product>().ToArray(); // اكني عملت Array فاضية 
            //Product[] products = new Product[0]; // اكني عملت كده 
            // الخلاصه انها بترجع collection فاضي

            //var Result = Enumerable.Empty<Product>().ToList(); // اكني عملت list فاضية 

            //Console.WriteLine(Result.Count); // 0
            //Console.WriteLine(Result.Capacity); // 0

            //Result.Add(new Product { ProductID = 10, ProductName = "mahmo" });

            //foreach (var item in Result)
            //    Console.Write($"{item} ");
            #endregion

            #region Set Operators [Union Family] - Deferred Execution

            //var sq01 = Enumerable.Range(0, 100);
            //var sq02 = Enumerable.Range(50, 100);

            //var Result = sq01.Union(sq02); // without dublicate هنا من 50 ->99 مشتركين فهاخدهم مره واحده فقط 
            //var Result = sq01.Concat(sq02); //  dublicate هنا من 50 ->99 مشتركين فهاخدهم  الاتنين  
            //var Result = sq01.Concat(sq02).Distinct(); //  هيرجعهم متكررين وبعد محط distincit هيشيل التكرار  (Concat + Distinct) => Union
            //*****************************************************************
            //var Result = sq01.Except(sq02).Distinct(); // هيجيب اللي موجود في sq01 ومش موجود في sq02
            //var Result = sq02.Except(sq01);   //  هيجيب اللي موجود في sq02 ومش موجود في sq01
            //******************************************************************
            //var Result = sq01.Intersect(sq02);

            //******************************************************************
            //int[] arr = new int[] { 1, 2, 3, 4, 45, 2, 3, 4, 5, 1, 2, 45, 5, 6 };
            //var Result = arr.Distinct();
            //*******************************************************************



            //foreach (var item in Result)
            //    Console.Write($"{item} ");


            #endregion

            #region Quantifier Operator - Return boolean
            //var Result = Products.Any(); // لو ال sequence فيه على الاقل عنصر واحد او اكتر من عنصر هيرجع true لو فاضي هيرجع false 
            // true 
            //var Result = Products.Any(p=> p.UnitsInStock == 0); // لازم على الاقل product واحد ي match ال condition 
            // True 
            //var Result = Products.Any(p => p.UnitsInStock == 1000000); // false 
            //************************************************************************************************************
            //var Result = Products.All(p=>p.UnitsInStock == 0); // هنا هيرجع false لان ال product كلها مش ب match condition
            // شرط اساسي ان مثلا كل ال product لازم ت match condition

            //var Result = Products.All(p=>p.UnitsInStock>=0); //  true
            //************************************************************************************************************
            //var sq01 = Enumerable.Range(0, 100);
            //var sq02 = Enumerable.Range(50, 100);
            //var Result = sq01.SequenceEqual(sq02); // false لان لاتنين مش بيساو بعض  
            //************************************************************************************************************
            //Console.WriteLine(Result);

            #endregion

            #region Zipping Operator - ZIP

            //string[] str = { "Mahmoud", "Mohamed", "Yousef", "Ibrahim", "Yousef"};
            //int[] arr = Enumerable.Range(1,100).ToArray();
            //char[] c = new char[] { 'A', 'B', 'C', 'D','E','F','G' };


            ////var result = str.Zip(arr); // هياخد على حسب minimum يعني هيمشي حسب str 

            //// another overload 
            ////var result = str.Zip(arr, (Name, Number) => new { index = Number, Name });// هام هام  // _____.Zip(______ , (هتاجد التايب على حسب caller , التايب على حسب parameter))
            ////*****************************************************************************************************
            //var result = str.Zip(arr, c); // هيمشي تبع اصغر length برضو يعني على حس str

            //foreach (var elem in result) Console.WriteLine(elem);

            #region Notes
            // الفكرة كلها عاملة زي فكرة اني بضغط ملف هنا بقى بضغط sequence 
            #endregion



            #endregion

            #region Grouping Operators

            #region Get Products Grouped by Category

            //var Result = from p in Products
            //             group p by p.Category;

            //Result = Products.GroupBy(p => p.Category);

            ////foreach (var item in Result)
            ////    Console.WriteLine(item); // اني اعمل كده ده غلط علشان اللي راجع IGrouping عباره عن <Category,Product>

            //// Solve Problem 

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    Console.WriteLine("-------------------------------");
            //    foreach (var P in Category)
            //        //Console.WriteLine($"        {P}");
            //        Console.WriteLine($"        {P.ProductName}");
            //}
            #endregion

            #region Get Products in Stock Grouped by Category

            //var Result = from p in Products
            //             where p.UnitsInStock > 0
            //             group p by p.Category;
            //Result = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    Console.WriteLine("-------------------------------");
            //    foreach (var P in Category)
            //        //Console.WriteLine($"        {P}");
            //        Console.WriteLine($"        {P.ProductName}");
            //}
            #endregion

            #region Get Products in Stock Grouped by Category That Contains More Than 10 Product
            //Dictionary<string, IGrouping<string, Product>> Result =
            //    (from p in Products
            //     where p.UnitsInStock > 0
            //     group p by p.Category
            //     into Category
            //     where Category.Count() > 10
            //     select Category)
            //    .ToDictionary(p => p.Key);


            //////Result = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var p in Category.Value)
            //        Console.WriteLine($"          {p.ProductName}");
            //}

            #endregion


            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            #region Solution 
            //var Result = from p in Products
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 CountProduct = Category.Count()
            //             };
            //// Fluent Syntax
            //Result = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Where(c => c.Count() > 10).Select(c => new
            //{
            //    CategoryName = c.Key,
            //    CountProduct = c.Count()
            //});
            //foreach (var elem in Result)
            //{
            //    Console.WriteLine(elem);
            //}
            #endregion

            #region another example
            //var Result = from p in Products
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 ProductName = from c in Category
            //                               select c.ProductName
            //             };
            //foreach (var elem in Result)
            //{
            //    Console.WriteLine(elem.CategoryName);
            //    foreach (var PName in elem.ProductName)
            //    {
            //        Console.WriteLine($"         {PName}");
            //    }
            //} 
            #endregion

            #endregion

            #endregion

            #region Partitioning Operators

            //var Result = Products.Where(p => p.UnitsInStock == 0).Take(2);// هيرجعلي اول اتنين products ال UnitsInStock == 0
            ////Result = Products.TakeLast(10); // هيرجعلي اخر عشره products
            //*******************************************
            //*******************************************

            //Result = Products.Where(p => p.UnitsInStock == 0).Skip(2); // هيتخطى اول اتنين product ال UnitsInStock == 0
            //Result = Products.SkipLast(10); // هيتخطى اخر عشره product 

            //*******************************************
            //*******************************************
            int[] numbers = { 1, 2, 3, 1, 4, 5, 9 };

            //var Result = numbers.TakeWhile(n => n < 4); //  1, 2, 3, 1 => هيطبع دول لان هو شغال لعند طول مل condition ب true اول لما يكون ب false يقف ويرجعلك اللي هو عدى عليهم 


            //var Result = numbers.SkipWhile(n => n < 4); // 4, 5, 9 => هيطبع دول لان هو شغال لعند طول مل condition ب true اول لما يكون ب false يقف ويرجعلك من بعد ما عمل skip  
            //*******************************************
            //*******************************************

            // طب هو لوعاوز تاني عشره product
            //var Result = Products.Skip(10).Take(10);

            // طب هو لوعاوز تالت عشره product

            //Result = Products.Skip(20).Take(10);
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

        }
    }
}
