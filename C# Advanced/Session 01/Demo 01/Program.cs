using System.Runtime.InteropServices;

namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Swap

            #region Manual
            //int x01 = 10, y01 = 20;
            //Console.WriteLine(x01);
            //Console.WriteLine(y01);
            //Console.WriteLine("After Swap");
            //Helper.Swap(ref x01, ref y01);
            //Console.WriteLine(x01);
            //Console.WriteLine(y01);

            //Console.WriteLine("====================");

            //decimal x02 = 5.2m, y02 = 10.2m;

            //Console.WriteLine(x02);
            //Console.WriteLine(y02);
            //Console.WriteLine("After Swap");
            //Helper.Swap(ref x02, ref y02);
            //Console.WriteLine(x02);
            //Console.WriteLine(y02);

            //Console.WriteLine("====================");

            //Point x03 = new Point(200, 300);
            //Point y03 = new Point(400, 500);

            //Console.WriteLine(x03);
            //Console.WriteLine(y03);
            //Console.WriteLine("After Swap");
            //Helper.Swap(ref x03, ref y03);
            //Console.WriteLine(x03);
            //Console.WriteLine(y03);

            // هنا في مشكلة في التكرار مع ان فيه overload بس ده مش حلو لان ال behavior متغيرش لان كل swap بتبدل رقمين فعلشان كده وحش
            // قبل 2005 كنا بنستخدم ال object وده برضو وحش لان انا بعمل boxing and unboxing وده بيضعف performance لان انا بعمل casting 

            #endregion

            #region Object 
            //object x01 = 10, y01 = 20;
            //Console.WriteLine(x01);
            //Console.WriteLine(y01);
            //Console.WriteLine("After Swap");
            //Helper.Swap(ref x01, ref y01);
            //Console.WriteLine(x01);
            //Console.WriteLine(y01);

            #endregion

            #region Generic
            //int x01 = 10, y01 = 20;
            //Console.WriteLine(x01);
            //Console.WriteLine(y01);
            //Console.WriteLine("After Swap");
            //Helper<int>.Swap/*<int>*/(ref x01, ref y01);// * Generic
            //Console.WriteLine(x01);
            //Console.WriteLine(y01);

            //Console.WriteLine("====================");

            //decimal x02 = 5.2m, y02 = 10.2m;

            //Console.WriteLine(x02);
            //Console.WriteLine(y02);
            //Console.WriteLine("After Swap");
            //Helper<decimal>.Swap(ref x02, ref y02); // لو روحت وقفت كل الفانكشن اللي اسمها Swap عادي تشيل Generic وهو هيتعرف عليها 
            //Console.WriteLine(x02);
            //Console.WriteLine(y02);

            //Console.WriteLine("====================");

            //Point x03 = new Point(200, 300);
            //Point y03 = new Point(400, 500);

            //Console.WriteLine(x03);
            //Console.WriteLine(y03);
            //Console.WriteLine("After Swap");
            //Helper<Point>.Swap/*<Point>*/(ref x03, ref y03); // علشان استخدمت ال Generic على مستوى الكلاس 
            //Console.WriteLine(x03);
            //Console.WriteLine(y03);
            #endregion

            #endregion


            #region Linear Search

            #region struct
            //int[] arr = { 1, 2, 3, 4, 4, 5 };
            //int pos = Helper<int>.LinearSearch(arr, 5);
            //Console.WriteLine(pos);

            //Point[] point = {
            //    new Point(1,2),
            //    new Point(10,20),
            //    new Point(100,200),
            //    new Point(1000,2000),
            //};

            //////point[0] == point[1]; // هنا == operator مش بيدعم user define struct 

            //Employee employee01 = new Employee(10, "Mahmoud", 4000);
            //Employee employee02 = new Employee(10, "Mahmoud", 4000);
            //// هنا == بتنفع لو كلاس بس هو مش بيساوي القيم ببعض ال == بتقارن هما بيشاورا على نفس ال object ولا لا مش بتقارن بالقيم طب علشان اقارن بالقيم لازم اعمل operator overload 
            //// طب لو struct ف == مش هتشتغل اصلا طب علشان اخليها تشتغل لازم اعمل عليها operator overloading 
            ////if (employee01==employee02)
            ////    Console.WriteLine("Equal");
            ////else
            ////    Console.WriteLine("Not Equal");
            ////**************************************************
            //// anathor way
            //if (employee01.Equals(employee02))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            ////**************************************************

            //Point[] points = {
            //    new Point(1,2),
            //    new Point(10,20),
            //    new Point(30,40),
            //    new Point(50,60),
            //    new Point(60,70)
            //};

            ////Point element = new Point(30, 40);
            ////int pos02 = Helper<Point>.LinearSearch(points, element); // هنا بقى ينفع اني اطبق ال generic لاني استخدمت Equals
            ////Console.WriteLine(pos02); 
            #endregion

            #region Class
            //Employee[] employee = {
            //new Employee(10,"Mahmoud",20),
            //new Employee(1000,"Mohamed",2000),
            //new Employee(1000,"Mohamed",2000),
            //new Employee(3000,"Sabry",40000),
            //};

            //Employee employee1 = new Employee(1000, "Mohamed", 2000);

            //int pos = Helper<Employee>.LinearSearch(employee, employee1);

            //Console.WriteLine(pos);

            ////if (employee[1] == employee[2])
            ////    Console.WriteLine("OK");
            ////else
            ////    Console.WriteLine("NO");

            //if (employee[1].Equals(employee[2])) // هنا هيروح على Equals بتاعت IEquatable علشان انا باعت Employee مباشرة
            //    Console.WriteLine("OK");
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region IEqualityComparer

            //Employee[] employee = {
            //new Employee(10,"Mahmoud",20),
            //new Employee(1000,"Mohamed",2000),
            //new Employee(1000,"Mohamed",2000),
            //new Employee(3000,"Sabry",40000),
            //};

            //Employee employee1 = new Employee(1000, "Mohamed", 2000);

            ////int pos =Helper<Employee>.LinearSearch(employee, employee1, new EmployeeNameIEquality());
            //int pos =Helper<Employee>.LinearSearch(employee, employee1, new EmployeeIdIEquality());
            //Console.WriteLine(pos);
            #endregion


            #endregion


            #region Bubble Sort
            string[] arr = { "Mahmoud", "Ahmed", "ahmed", "Sara" }; //“Int32 struct .NET IComparable IEquatable”
            Helper<string>.BubbleSort(arr);
            foreach (string elem in arr)
                Console.Write($"{elem} ");

            Employee[] employee = {
            new Employee(10,"Mahmoud",20),
            new Employee(1000,"Mohamed",2000),
            new Employee(1000,"Mohamed",2000),
            new Employee(3000,"Mahmoud",40000),
            };

            //Helper<Employee>.BubbleSort(employee);
            //foreach (Employee elem in employee)
            //    Console.Write($"{elem.Salary} ");

            Helper<Employee>.BubbleSort(employee, new EmployeeID());
            foreach (Employee elem in employee)
                Console.Write($"{elem.Salary} ");
            #endregion


        }
    }
}
