using Demo_06.Abstraction01;
using Demo_06.Built_In_Interface;
using System.Drawing;
using System.Security.Claims;
using System.Text;

namespace Demo_06
{
    internal class Program
    {
        static void ProcessFun(Shape shape)
        {
            if (shape is not null)
            {
                Console.WriteLine(shape.Premiter);
                Console.WriteLine(shape.calcArea());
            }
        }
        static void Main(string[] args)
        {
            #region Shallow Copy and Deep Copy

            #region Array of Value Type

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"Hash Code of Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code of Arr02 : {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;// Shallow Copy
            //              // Copy value of Arr01 to Arr02
            //              // Copy Addresses - Happend in stack --> باخد نسخه من العنوان اللي موجود في stack
            //              // [Arr01 -Arr02] the same value 
            //              // [Arr01 - Arr02] refer same object 
            //Console.WriteLine("After Shallow");
            //Console.WriteLine("--------------------------");

            //Console.WriteLine($"Hash Code of Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code of Arr02 : {Arr02.GetHashCode()}");

            //Console.WriteLine($"Value of Arr01[0] : {Arr01[0]}");
            //Console.WriteLine($"Value of Arr02[0] : {Arr02[0]}");

            //Arr02[0] = 10;
            //Console.WriteLine("-------------------------");
            //Console.WriteLine($"Value of Arr01[0] : {Arr01[0]}");
            //Console.WriteLine($"Value of Arr02[0] : {Arr02[0]}"); 
            #endregion

            #region Deep Copy
            //Arr02 = (int[])Arr01.Clone();// Deep Copy
            //                             // Happend in heap
            //                             // Create New Object With Different and New Identity then return it 
            //                             //        يعني هنشئ object جديد مع عنوان جديد في heap
            //                             // the new object will have the same state[Data] of caller Arr01
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine("----------------------");
            //Console.WriteLine($"Hash Code of Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code of Arr02 : {Arr02.GetHashCode()}");

            //Console.WriteLine($"Value of Arr01[0] : {Arr01[0]}");
            //Console.WriteLine($"Value of Arr02[0] : {Arr02[0]}");

            //Arr02[0] = 10;
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"Value of Arr01[0] : {Arr01[0]}");
            //Console.WriteLine($"Value of Arr02[0] : {Arr02[0]}");

            #endregion




            #endregion

            #region Array of Reference Type [String]
            //string[] names01 = { "Mahmoud", "Omar"};
            //string[] names02=new string[2];

            //Console.WriteLine($"Hash Code of names01 : {names01.GetHashCode()}");
            //Console.WriteLine($"Hash Code of names02 : {names02.GetHashCode()}");

            #region Shallow Copy
            //Console.WriteLine("---------------------------------");
            //names02 = names01;// Shallow Copy
            //                  // Copy value of names01 to names02
            //                  // Copy Addresses - Happend in stack --> باخد نسخه من العنوان اللي موجود في stack
            //                  // [Arr01 -Arr02] the same value 
            //                  // [Arr01 - Arr02] refer same object 
            //Console.WriteLine("After shallow copy.");
            //Console.WriteLine($"Hash Code of names01 : {names01.GetHashCode()}");
            //Console.WriteLine($"Hash Code of names02 : {names02.GetHashCode()}");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine($"Value of names01[0] : {names01[0]}");
            //Console.WriteLine($"Value of names02[0] : {names02[0]}");

            //names02[0] = "Mostafa";

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"Value of names01[0] : {names01[0]}"); 
            //Console.WriteLine($"Value of names02[0] : {names02[0]}"); // هتكون نفس name01 لان هيا بتشاور على نفس reference مش زي Deep على object مختلف
            #endregion

            #region Deep Copy 

            //names02 = (string[])names01.Clone();//هنا colne بيعمل shallow copy لان هو ايو بيعمل نسخه في heap بس النسخة اللي عملها فيها reference تانية الreference اللي موجوده في name02 دي جايه من name01 وده اسمه shallow انه خد نسخه من reference
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine($"Hash Code of names01 : {names01.GetHashCode()}");
            //Console.WriteLine($"Hash Code of names02 : {names02.GetHashCode()}");

            //Console.WriteLine($"Value of names01[0] : {names01[0]}");
            //Console.WriteLine($"Value of names02[0] : {names02[0]}");
            //Console.WriteLine("---------------------------------");

            //names01[0] = "Mostafa";
            //Console.WriteLine("After changing");
            //Console.WriteLine($"Value of names01[0] : {names01[0]}"); // القيمه هتتغير هنا بس لانه عمل نسخه جديده وهيغير في نسخته بس 
            //Console.WriteLine($"Value of names02[0] : {names02[0]}");

            #endregion

            #endregion

            #region Array of Reference Type [StringBuilder]
            //StringBuilder[] names = new StringBuilder[1];
            //names[0].Append("Mahmoud");//System.NullReferenceException:لان انت بتضيف ومفيش اوبجكت في heap اصلا

            //solve problem
            //StringBuilder[] names = [new StringBuilder(2), new StringBuilder(2)];//(2)->Capacity
            //StringBuilder[] stringBuilder = new StringBuilder[1];
            //names[0].Append("Ahmed");
            //names[1].Append("Salwa");

            //Console.WriteLine($"Hash Code of names01 : {names.GetHashCode()}");
            //Console.WriteLine($"Hash Code of names02 : {stringBuilder.GetHashCode()}");

            #region Shallow Copy
            //stringBuilder = names;
            //Console.WriteLine("After Shallow");
            //Console.WriteLine($"Hash Code of names01 : {names.GetHashCode()}");
            //Console.WriteLine($"Hash Code of names02 : {stringBuilder.GetHashCode()}");
            //Console.WriteLine(ReferenceEquals(names, stringBuilder));
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine(names[0]);
            //Console.WriteLine(stringBuilder[0]);
            //names[0].Append(" Salama");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine(names[0]);
            //Console.WriteLine(stringBuilder[0]);
            #endregion

            #region Deep Copy 
            //stringBuilder = (StringBuilder[])names.Clone();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash Code of names01 : {names.GetHashCode()}");
            //Console.WriteLine($"Hash Code of names02 : {stringBuilder.GetHashCode()}");
            //Console.WriteLine(ReferenceEquals(names, stringBuilder));//False لانه مش نفس مكان في ال heap
            //Console.WriteLine(ReferenceEquals(names[0], stringBuilder[0]));// True اه هما مش بيشاورو على نفس المكان بس بيشاوروا على نفس القيم 
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(names[0]);
            //Console.WriteLine(stringBuilder[0]);
            //names[0].Append("Saad");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("After Changing");
            //Console.WriteLine(names[0]);
            //Console.WriteLine(stringBuilder[0]);

            #endregion
            #endregion

            #endregion

            #region ICloneable
            //Employee employee01 = new Employee() { Id = 10, Name = "Mahmoud", Salary = 4000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "Ahmed", Salary = 8000 };

            //Console.WriteLine($"Employee One - Hash Code = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee Two - Hash Code = {employee02.GetHashCode()}");
            //Console.WriteLine($"Reference -> {ReferenceEquals(employee01, employee02)}");
            //Console.WriteLine("-----------------------------");

            //employee02 = (Employee)employee01.Clone();// Clone Method : This Method Generates new Object With New  and Different Identity
            //                                          // This Object Will Have Same Object State [Data] of Caller Object  

            ////// 2nd Way To Do Deep Copy [Copy Constructor]
            ////// Copy Constructor : is a Special Constructor Used To Make a Deep Copy For Reference Type Object 
            ////employee02 = new Employee(employee01);
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Employee One - Hash Code = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee Two - Hash Code = {employee02.GetHashCode()}");
            //Console.WriteLine($"Reference -> {ReferenceEquals(employee01, employee02)}");

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine($"Employee One - Id = {employee01}");
            //Console.WriteLine($"Employee Two - Id = {employee02}");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("After Changing");
            //employee01.Id = 30;
            //Console.WriteLine($"Employee One - Id = {employee01}");
            //Console.WriteLine($"Employee Two - Id = {employee02}");
            #endregion

            #region IComparable
            //int[] numbers = { 1, 2, 3, -1, 0, 1, 5 };
            //Array.Sort(numbers);// ال sort بتستخدم IComparable 
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //***************************************************************
            //Problem 
            //Employee[] employees =
            //{
            //    new Employee(){Id= 10 , Name = "Omar" , Salary = 6000},
            //    new Employee(){Id= 20 , Name = "Ahmed" , Salary = 10000},
            //    new Employee(){Id= 30 , Name = "Sama" , Salary = 4000},
            //    new Employee(){Id= 40 , Name = "May" , Salary = 5000},
            //};
            //Array.Sort(employees);// هيروح يدور على IComparable مش هيلقيها 
            //****************************************************************
            // Slove Problem
            //Array.Sort(employees);
            //Array.Reverse(employees);// دي عادي لان مش لازم استخدم IComparable
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region IComparer
            Employee[] employees =
                {
                new Employee(){Id= 10 , Name = "Ahmed" , Salary = 6000},
                new Employee(){Id= 20 , Name = "Ahmed" , Salary = 10000},
                new Employee(){Id= 30 , Name = "Sama" , Salary = 4000},
                new Employee(){Id= 40 , Name = "Ahmed" , Salary = 5000},
            };

            Array.Sort(employees, new EmployeeNameCompare());
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Abstraction 

            #region Problem and solve
            //            مشكلة قبل الـ Abstract Class إن مفيش عقد يجبر الكلاسات المختلفة يكون فيها نفس الأساسيات، وده بيعمل لخبطة وأخطاء وقت التنفيذ.
            //الـ Abstract Class جه عشان:
            //            يعمل عقد واضح للكلاسات.
            //يوفر نوع مشترك لكل المشتقات.
            //يجبرك على الالتزام بالأساسيات.
            //يسمح بالـ Polymorphism.
            #endregion


            ////Shape shape = new Shape();
            //// Cannot create an instance of the abstract type or interface 'Shape'
            //// But You Can Create a Reference From Abstract Class Refer To An Object
            //// From Class That Inherit and Implement Abstract Class

            //Abstraction01.Rectangle rectangle = new Abstraction01.Rectangle(10,20) { Dim01=8.5m,Dim02=7.4m};
            //ProcessFun(rectangle);

            #endregion

        }
    }
}
