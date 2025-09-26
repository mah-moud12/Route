
using static Data01.ListGeneratorHelpers;
using System.Collections;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using Data01;

namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable [var , dynamic]

            #region var
            ////string data = "Mahmoud"; 

            //var data = "Mahmoud"; // Implicitly Typed 
            //                      // Compiler Will Detect Data Type Of Variable At Compilation Time 
            //                      // Based On Its Initial Value.

            ////var data =null; // Invalid لان هو بيحدد الداتا تايب ل initial value و ال null ملهاش تايب 

            //data = null; // ده كده عادي لان انا حددت الداتا تايب وعادي اعدل عليه ب null
            //             //data = 11; // Invalid لان انا حددت الداتا تايب وال compiler حددو ان هو string ف لما اجي اعدل عليه وادخلو intger كده غلط
            ////var x; // Invalid علشان هو مش لاقي هيحدد initial value ازاي مفيش value اصلا يحددها 

            //Console.WriteLine(data);
            #endregion

            #region dynamic 
            //// CLR Will Detect Data Type Of Variable At RunTime 
            //// Based On Last Assign Value

            //dynamic x; // مش غلط اللي انا اعمل كده بس لو فضلت كده من غير معمل assign value لل x هيضرب error لما اجي استخدمه 
            ////Console.WriteLine(x);// error

            //x = null; // مش غلط اللي انا اعمل كده بس لو فضلت كده من غير معمل assign value لل x هيضرب exception لما اجي استخدمه 
            ////Console.WriteLine(x); // RuntimeBinderException

            //x = 10;// كده last value هتتحدد int
            //Console.WriteLine(x); // valid

            //x = true;// كده last value هتتحدد boolean
            //Console.WriteLine(x);


            #endregion

            #region Note 
            // var and dynamic: 
            //     * مينفعش ابصيهم ك parameter
            //     * مينفعش اعمل return ليهم 
            //     * مينفعش اعرف attribute في الكلاس على انهم var and dynamic 
            //***************************************************************
            //     * لو هستخمهم لازم استخدمه ك local زي جو function and for and foreach وهكدا 
            //     * الافضل اني استخدم var لانها بتظهرلي error في Compilation time وديه ميزه بدل ما اكون مش عارف error هيجي امتى 
            //foreach (var item in new int []{1,2,3,4 })
            //    Console.WriteLine(item);

            //for (dynamic i = 0; i < new int[] { 1, 2, 3, 4 }.Length; i++)
            //    Console.WriteLine(i);
            #endregion

            #endregion

            #region Extention Method

            //int x = 123;
            ////x = ExtentionMethod.Reverse(x);
            ////x = x.Reverse();//error مينفعش اعمل كده لان مفيش جو struct int الفانكشن اللي اسمها Reverse طب لو عاوز اعدلها روح على class Extention وضيف this 

            //x = x.Reverse();

            //Console.WriteLine(x);

            #endregion

            #region Anonymous 

            //Employee employee = new Employee { Id = 10, Name = "Mahmoud", Salary = 3000 };
            ////Console.WriteLine(employee);
            //// ده شغال بس مش حلو لاني عاوز استخدم الاوبجكت ده مره واحده ف مش هروح اعرف كلاس وانا عاوز استخدم الاوبجكت مره واحده 

            //object Emp01 = new { Id = 10, Name = "Mahmoud", Salary = 2000 };
            ////Console.WriteLine(Emp01.Id); // كده مش هينفع استخدم من Emp01 ال Id لان ال Object من جواه مفيش  Id ف الحل ده مش هينفع 

            //// Solve Problem using Anonymous Typed

            ////علشان اعرف ال Anonymous بعرفها ب var

            //var Emp02 = new { Id = 10, Name = "Mahmoud", Salary = 2000 };
            ////Console.WriteLine(Emp02.Id);


            //Console.WriteLine(Emp02.GetType().Name); // <>f__AnonymousType0`3 => <>f__AnonymousType[number Anonymous]`[number properties]
            //var Emp03 = new { Id = Emp02.Id, Name = Emp02.Name, Salary = 3000 }; // C# 09
            //var Emp04 = Emp02 with { Salary = 34560 }; // C# 10

            ////-----------------------------------------
            //// Anonymous Typed => immutable 

            ////Emp02.Id = 20; //error
            //Console.WriteLine(Emp02.Salary); // هتلاقيها متاثرتش بتغيير Emp03 and Emp04 
            ////-----------------------------------------


            //Console.WriteLine(Emp02); // هيطبع هيا by default معمولها override To string
            //Console.WriteLine(Emp03);
            //Console.WriteLine(Emp04);
            //Console.WriteLine("=======================");
            //Console.WriteLine(Emp02.GetType().Name); // <>f__AnonymousType0`3
            //Console.WriteLine(Emp03.GetType().Name); // <>f__AnonymousType0`3
            //Console.WriteLine(Emp04.GetType().Name); //<>f__AnonymousType0`3
            //Console.WriteLine("=======================");
            //// The Same Anonymous Type as long as :
            ////     * Same Properties Name [Case Senstive] 
            ////     * Same Properties Order

            //var Emp05 = new { id = Emp02.Id, Name = Emp02.Name, Salary = 3000 }; // Not the Same Properties Name
            //var Emp06 = new { Name = Emp02.Name, id = Emp02.Id, Salary = 3000 }; // Not the Same Properties Order
            //var Emp07 = new { id = Emp02.Id, Name = Emp02.Name };

            //Console.WriteLine(Emp05.GetType().Name); // <>f__AnonymousType1`3
            //Console.WriteLine(Emp06.GetType().Name); // <>f__AnonymousType2`3
            //Console.WriteLine(Emp07.GetType().Name); //<>f__AnonymousType3`2
            #endregion

            #region What is LINQ
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }; // Sequence Of Data => Static -> L2Object 
            //List<int> OddNumber = Numbers.Where(num => num % 2 != 0).ToList(); //  لازم اعمل ToList علشان هيا بترجع حاجه من نوع IEnumrable
            //                                                                   // Numbers.Where => بتتحول في compilation time ل IEnumrable<T>.Where
            //foreach (var item in OddNumber)
            //    Console.Write($"{item} ");
            #endregion

            #region Linq Syntax 

            #region 1.Fluent Syntax
            //List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            ////   1.1 Call "LINQ Operators" as Static Method
            ////List<int> OddNumbers = Enumerable.Where(list,num => num % 2 != 0).ToList();
            ////***************************************************************************

            ////    1.2 Call "LINQ Operators" As Extension Method[Recommended]
            //List<int> OddNumbers = list.Where(num=>num%2!=0).ToList();
            //foreach (var item in OddNumbers)
            //    Console.WriteLine(item);
            #endregion

            #region 2.Query Syntax
            //// SQL
            //// select *
            //// from list l
            //// where l % 2 == 0


            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var OddNumber = (from N in list // بكتب Query Syntax بترتيب تنفيدها مش زي Sql
            //                 where N % 2 != 0
            //                 select N)/*.ToList()*/;

            //foreach (var item in OddNumber)
            //    Console.WriteLine( item);


            //// Two Condition:
            ////  * Must Be Begin With Keyword 'From'
            ////  * Must be End With Select Or Groupby
            #endregion
            #endregion

            #region LINQ  Execution Ways

            #region Deferred Execution [Latest Version Of Data] 
            //// مؤجل لعند الاستخدام 
            //List<int> Numbers = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            //// flunet syntax -> Extention Method
            //var OddNumber = Numbers.Where(num => num % 2 != 0); // مش هتتنفد الا لما استخدم OddNumbers
            //Numbers.InsertRange(0, new List<int>() {-3,-2,-1,0 }); // هيضيفها مع Odd Number علشان ال Query Deffered Execution

            //foreach (var item in OddNumber)
            //    Console.WriteLine($"{item} ");

            #endregion

            #region Immediate Execution
            //// دلوقتي 
            //// علشان استخدمها لازم استخدم معاها واحده من دول    ( Elements Operators , Casting Operators ,Aggregate Operators )
            //List<int> Numbers = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            //// flunet syntax -> Extention Method
            //List<int> OddNumber = Numbers.Where(num => num % 2 != 0).ToList(); //  هتتنفد دلوقتي اي تاثير على Numbers بعد كده مش هتتاثر لانها اتنفدت خلاص
            //Numbers.InsertRange(0, new List<int>() {-3,-2,-1,0 }); //مش هيضيفها مع OddNumbers

            //foreach (var item in OddNumber)
            //    Console.WriteLine($"{item} ");

            #endregion

            #endregion

            #region DataSetup
            //Product product = Products[0];
            //Customer customer = Customers[0];
            //Console.WriteLine(product);
            //Console.WriteLine(customer);
            #endregion

            #region LINQ Categories 

            #region Filtration [Restrication] Operators - Where 

            #region Get Elements Out Of Stock
            //1.Fluent Syntax
           var Result = Products?.Where(p => p?.UnitsInStock == 0); // Deferred Execution

            // 2.Query Syntax
            //var Result = from p in Products
            //             where p?.UnitsInStock == 0
            //             select p;

            //foreach (var item in Result)
            //    Console.WriteLine($"{item} ");
            #endregion

            #region Get Elements In Stock And In Category Of Meat/Poultry 
            //// 1.Fluent Syntax
            ////List<Product>? result = Products?.Where(p => p?.UnitsInStock > 0 && p?.Category == "Meat/Poultry").ToList();// Immediate Execution

            //// 2.Query Syntax
            //List<Product> result = (from p in Products
            //                        where p?.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //                        select p).ToList();

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region another overload where
            // 1. Only Fluent Syntax
            // indexed where 
            //var result = Products.Where((p, i) => p.UnitsInStock == 0 && i < 10);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region Transformation [Projection] Operators [Select , Select Many]

            #region Select Product Name
            //// 1. Fluent Syntax
            //var result = Products.Select(p => p.ProductName);

            //// 2. Query Syntax
            //result = from p in Products
            //         select p.ProductName;

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Select Customer Name
            //// 1. Fluent Syntax
            //var result = Customers.Select(c => c.CustomerName);

            //// 2. Query Syntax
            //result = from c in Customers
            //         select c.CustomerName;
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Select Customer Orders

            //var result = Customers.SelectMany(c => c.Orders); // علشان احدد كولكشن لازم استخدم selectMany

            //var result = from c in Customers
            //         from o in c.Orders
            //         select o;
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Select Product Id and Product Name 

            //var result = Products.Select(p=>$"ProductID= {p.ProductID}, ProductName= {p.ProductName}"); // One Solution
            //var result = Products.Select(p => new Product { ProductID = p.ProductID, ProductName = p.ProductName });// ده غلط لان هيرجع داتا غلط هيساوي ProductId and ProductName والباقي defualt اما انا عاوز حاجتين بس 
            // الحل اني اعمل class فيه productID and ProductName بس علشان نحل مشكلة انه يجيب باقي العناصر التانيه
            // Solve Problem
            //Product02 result = (Product02)(Products.Select(p => new Product02 { ProductId = p.ProductID, ProductName = p.ProductName }));// الحل ده مش افضل حاجه علشان انا عمل class وهستخدمه مرة واحده بس ف الحل الصحيح اني اعمل Anonymous Type
            //var result = Products.Select(p => new { ProductId = p.ProductID, ProductName = p.ProductName });// هنا هيطبع لانه معمولها override على ToString
            //*********************************************************************************

            //var result = from p in Products
            //         select  $"ProductID= {p.ProductID}, ProductName= {p.ProductName}";

            //var result = from p in Products
            //             select new
            //             {
            //                 productId=p.ProductID,
            //                 ProductName=p.ProductName
            //             };
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Select Product In Stock And Apply Discount 10 % On Its Price
            //var result = Products.Where(p => p.UnitsInStock > 0).Select(p => new
            //{
            //    ProductID = p.ProductID,
            //    OlderPrice = p.UnitPrice,
            //    NewPrice = p.UnitPrice - (p.UnitPrice * 0.1m)
            //});

            //result = from p in Products // مش هتضرب error لانها بترجع نفس ناتج الاولى 
            //         where p.UnitsInStock > 0
            //         select new
            //         {
            //             ProductID = p.ProductID,
            //             OlderPrice = p.UnitPrice,
            //             NewPrice = p.UnitPrice - (p.UnitPrice * 0.1m)
            //         }; 
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Indexed Selected Only fluent
            //var result = Products.Select((p, i) => new
            //{
            //    Indexed = i+1,
            //    ProductName = p.ProductName
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]

            #region Get Products Ordered By Price Asc
            //var list = Products.OrderBy(p => p.UnitPrice); // Ascending 

            //list = from p in Products
            //       orderby p.UnitPrice
            //       select p;

            #endregion

            #region Get Products Ordered By Price Desc
            var list = Products.OrderByDescending(p => p.UnitPrice);
            list = Products.OrderByDescending(p => p.UnitPrice);

            list = from p in Products
                   orderby p.UnitPrice descending
                   select p;
            #endregion

            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            //// لو عاوز ارتب بحاجتين  

            //var list = Products.OrderByDescending(p => p.UnitPrice).ThenBy(p => p.UnitsInStock).Reverse(); // thenby لومتساويين هيرتب على حاجه تانية اللي هيا UnitsInStock 
            //list = Products.OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock); // thenby لومتساويين هيرتب على حاجه تانية اللي هيا UnitsInStock

            //list = (from p in Products
            //       orderby p.UnitPrice descending
            //       select p).ThenByDescending(p=>p.UnitsInStock);

            #endregion
            //foreach (Product elem in list) Console.WriteLine(elem);

            #endregion

            #region Elements Operator - Immediate Execution [Valid Only With Fluent Syntax]

            #region First and FirstOrDefault
            // List<Product> elem = new List<Product>();
            // Product product = Products.First(p => p.UnitsInStock == 0); // هيرجع اول product ب match condition بس هيا unsafe
            // Product product01 = elem.First(p => p.UnitsInStock == 0); //exception علشان كده هيا unsafe 

            // Solve Problem Exception
            //Product? product01 = elem.FirstOrDefault(p => p.UnitsInStock == 0); // لو مفيش عناصر هترجع ب null
            // Console.WriteLine(product01?.ProductID);
            #endregion

            #region Last and LastOrDefault
            //List<Product> elem = new List<Product>();
            //Product product = Products.Last(p => p.UnitsInStock == 0); // هيرجع اخر product ب match condition بس هيا unsafe
            ////Product product01 = elem.Last(p => p.UnitsInStock == 0); //exception علشان كده هيا unsafe 

            ////Solve Problem Exception
            //Product? product01 = elem.LastOrDefault(p => p.UnitsInStock == 0); // لو مفيش عناصر هترجع ب null
            //Console.WriteLine(product01?.ProductID); 
            //Console.WriteLine(product); 

            #endregion

            #region ElementAt and ElementAtOrDefault
            //List<Product> elem = new List<Product>();
            //Product product = Products.ElementAt(1); //unsafe
            //////Product product01 = elem.ElementAt(0);//exception علشان كده هيا unsafe 

            ////// Solve Problem Exception
            //Product? product01 = elem.ElementAtOrDefault(1); // لو مفيش عناصر هترجع ب null
            //Console.WriteLine(product01?.ProductID);
            //Console.WriteLine(product);
            #endregion

            #region Single and SingleOrDefault 
            //// لو ال list مفيهاش product او فيها اكتر من product في الحالتين دول هيضرب exception 
            //// لو list فيها product واحد بس هيجيبو مش هيضرب exception 
            //List<Product> elem = new List<Product>();
            ////Product product = Products.Single(); //unsafe => exception
            ////Product product = elem.Single(); //unsafe => exception
            //elem = [new Product { ProductID = 10, ProductName = "Chai", UnitPrice = 20, UnitsInStock = 100, Category = "---" }];
            //Product product = elem.Single(); // valid
            //Console.WriteLine(product);
            ////*********************************************************************
            //List<Product> elem = new List<Product>();
            ////Product product = elem.SingleOrDefault(); // null =>  علشان لو فاضية مش هيضرب exception

            ////Product product = Products.SingleOrDefault(); //unsafe => exception => علشان لو فيها اكتر من product هيضرب exception

            //elem = [new Product { ProductID = 10, ProductName = "Chai", UnitPrice = 20, UnitsInStock = 100, Category = "---" }];
            //Product product = elem.Single(); // valid
            //Console.WriteLine(product);
            #endregion

            #region Hybird Approach
            //// hybrid approach => query syntax + fluent syntax
            //// (query syntax).(fluent syntax)
            //List<Product> elem = new List<Product>();
            //var list = (from p in Products
            //           where(p.UnitsInStock==0)
            //           select p).First();
            //Console.WriteLine(list);
            ////foreach (var item in list) Console.WriteLine(item);
            #endregion

            #endregion

            #region  Aggregate Operators  - Immediate Execution

            //var Max01 = Products.Max();// Exception علشان انت مش حددت انت عاوز ترتب بناء على اي علشان نحل المشكلة دي لازم اروح اعمل implement Icomparable
            //Console.WriteLine(Max01);
            ////*******************************************************************************
            ////var Max02 = Products.Max(p=>p.UnitPrice);
            ////Console.WriteLine(Max01);
            //////*******************************************************************************
            ////var MaxLength = Products.Max(p=>p.ProductName.Length);

            ////var GetElementMaxLength = (from p in Products
            ////                          where p.ProductName.Length == MaxLength
            ////                          select p).FirstOrDefault();
            ////Console.WriteLine(GetElementMaxLength);
            //////*******************************************************************************

            //var Total = Products.Sum(p => p.UnitPrice);
            //Console.WriteLine(Total);
            //////*******************************************************************************
            //var Avg = Products.Count(p => p.UnitsInStock == 0);
            //Console.WriteLine(Avg);
            #endregion



            #endregion
        }
    }
}
