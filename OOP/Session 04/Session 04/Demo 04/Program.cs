using Demo_04.Overloading;
using Demo_04.Overriding;
using System.Collections.Specialized;
using System.Numerics;

namespace Demo_04
{
    internal class Program
    {
        #region Overload 

        #region Bad
        //المشكلة اللي حلتها Overloading
        //ده مش حلو لا في القرأة ولا في الصيانه لان في كدا اسم فانكشن وانا هفضل ادور
        //"Even if the method names are the same, overloading helps group logically related functionality in one place. This improves readability and makes maintenance easier, especially with IDE support."
        //حتى لو أسماء الدوال واحدة، الـ Overloading بيستفيد جدًا من دعم الـ IDEs اللي بتخلي التنقل بين النسخ المختلفة واضح وسلس، وده بيسهّل قراءة الكود وصيانته بشكل كبير.
        //Integrated Development Environment(IDE)

        private static int sumTwo(int a, int b)
        {
            return a + b;
        }
        private static int sumThree(int a, int b, int c)
        {
            return a + b + c;
        }
        private static int sumDoubleAndInteger(double a, int b)
        {
            return (int)a + b;
        }
        #endregion

        #region Good
        private static int sum(int a, int b)
        {
            return a + b;
        }
        private static int sum(int a, int b, int c)
        {
            return a + b + c;
        }
        private static int sum(double a, int b)
        {
            return (int)a + b;
        }
        private static double sum(int a, double b)
        {
            return a + b;
        }
        private static double sum(double a, double b)
        {
            return a + b;
        } 
        #endregion

        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism

            #region Intro
            // - Overload: 
            //    * مش لازم يكون فيه inhertance 
            //    * بيكون في كدا فانكشن نفس الاسم واللي بيفرق بينهم انهم كل واحده بتحتوي علي عدد parameter مختلف وبرضو ممكن يكون انواع البارمتر مختلف
            //    * وبرضو ترتيبهم overload
            //--------------------------------------------------------------------------------------------------
            // - Override:
            //    *  لازم يكون فيه inhertance 
            //    *   بتكون فانكشن انا وارثها وبعمل عليها override ياما اعدل على behavior بتاعها ياما ازود عليه
            #endregion

            #region Overloading

            #region Methods Overloading 
            //"Method overloading helps me keep my code clean and readable by using the same method name for different logic depending on input parameters.
            //It improves clarity and manageability without any impact on performance."
            //-------------------------------------------------------------------------------------------------
            //int a = 10, b = 20, result01 = sum(a, b);
            //int result02 = sum(10.2,10);
            //Console.WriteLine(result01);
            //--------------------------------------------------------------------------------------------------
            //Overload 
            //Console.WriteLine('C');
            //Console.WriteLine("Mahmoud");
            //Console.WriteLine(12);
            //Console.WriteLine(12.3m);
            #endregion

            #region Operator Overloading

            //Complex01 C1 = new Complex01(10, 50)
            //{//ده اللي هيتنفد الطريقة دي اسمها Object initializer
            //    Real = 10,
            //    Img = 5,
            //};
            //Console.WriteLine($"C1 : {C1}");

            //Complex01 C2 = new Complex01(10, 50);
            //Console.WriteLine($"C2 : {C2}");
            ////------------------------------------------------------------------------------------------
            ////------------------------------------------------------------------------------------------

            ////Binary Overloading
            ////Complex01 C3 = null + C2; // Exception => solve using Conditional nullable => prodective code 
            //Complex01 C3 = C1 + C2;
            //Console.WriteLine("==========================");
            //Console.WriteLine($"C3 : {C3}");

            ////Unary Overloading
            //C3++;
            //Console.WriteLine("==========================");
            //Console.WriteLine($"Incrteasing C3 {C3}");

            ////Relational Overloading
            //Console.WriteLine("==========================");
            //if (C1 > C2) Console.WriteLine("C1 > C2");
            //else Console.WriteLine("C1 < C2");

            ////Casting Overloading
            ////Example 01
            //int X = (int)C1;
            //Console.WriteLine("==========================");
            //Console.WriteLine($"X : {X}");

            //string? Y = C1;
            //Console.WriteLine("==========================");
            //Console.WriteLine($"Y : {Y}");

            //Example 02
            //User U01 = new User
            //{
            //    Id = 10,
            //    FullName = "Mahmoud Mohamed",
            //    Email = "maboyousef681@gmail.com",
            //    Password="P@ssw0rd",
            //    SecurityStamp = Guid.NewGuid()
            //};
            //// Mapping Manual
            //UserViewModel UVM01 = (UserViewModel)U01;
            //Console.WriteLine(UVM01.Id);
            //Console.WriteLine(UVM01.FirstName);
            //Console.WriteLine(UVM01.LastName);
            //Console.WriteLine(UVM01.Email);
            #endregion


            #endregion

            #region Overriding
            //TypeA typeA = new TypeB(5,300);
            //typeA.A = 20;
            //typeA.MyFun01();
            //typeA.MyFun02();
            //Console.WriteLine("===================");
            //TypeB typeB = new TypeB(5,10);
            //typeB.B = 20;
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion

            #endregion

        }
    }
}
