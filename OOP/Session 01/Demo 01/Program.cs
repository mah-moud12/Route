using ClassLibrary_01;
using Demo_01.Enumsss;
using System.Net.Http.Headers;
namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting [Boxing - Unboxing] 

            #region Boxing [Value Type => Reference Type]
            ////follow presentation
            ////Converting a value type to a reference type (object)
            ////يعني باخد Data Type اللي نوعها value type ومتخزنه في ال Stack واحطها في object في heap

            //int X = 100;

            //object obj = X;//implicit[Safe]
            ////object obj = (object)X;   //معملتش Explicit لإن ال Object يقدر يشيل اي حاجه

            //obj = 1.2;//boxing
            //obj = 'A';//boxing
            #endregion

            #region Unboxing [Reference Type => Value Type]
            ////Converting a reference type to a value type (object)
            ////هنا شيلت الحاجه من boxing اللي في heap وحطتها في stack 

            //object obj = 20;

            //int X = (int)obj;//Explicit Casting [Unsafe]

            //object obj02 = "mahmoud";
            //int Y = (int)obj02;//System.InvalidCastException:

            #endregion

            #endregion

            #region Nullable Value type

            #region Example01
            ////مفيش اي Data Type نوعها value type كانت بتقبل null قبل 2005
            ////في 2005 في C# 2.0 حلو مشكلة ان Value type تقبل null
            ////طب لي عملو ان value type تقبل ال null ? لو عندك مثلًا معلومة عن "عمر شخص"، ومش عارف عمره لسه فهتلجأ انك تخليه ب null علشان تقدر handle data base.

            //int age;
            ////age = null; // invalid

            //Nullable<int> X = null;

            //Console.WriteLine(X);// هيطبع سطر فاضي 

            //int? Y = null;
            //Console.WriteLine(Y);// هيطبع سطر فاضي 


            #endregion

            #region Example02

            //int X = 20;
            //int? Y = X;//Implicit Casting
            //// Slow Performance علشان لسه بيعمل Casting وده بيكون سبب ان هو يكون بطئ
            ////----------------------------------------------------------------------------
            //int? Z = null;
            ////int W = (int)Z;// System.InvalidOperationException
            ////لإن هو مش عارف لإن ممكن يكون رقم او null فمش هيعرف يحول null



            ////solve problem
            //int W;
            //if (Z is not null)
            //{
            //    W = (int)Z;
            //}
            //else
            //    W = 0;

            //W = Z.HasValue ? (int)Z : 0;
            //W = Z.HasValue ? Z.Value : 0;

            //W = Z.GetValueOrDefault();//لو هيا مش null هترجع Zero

            //W = Z ?? 0;//Null-Coalescing Operator



            #endregion

            #endregion

            #region Nullable Reference type
            //            String? Name = null;//هنا بقولهه خلي بالك reference Type دي بتقبل null
            //            Console.WriteLine(Name);// هيطبع سطر فاضي 

            //            //بص على Data annotation وخليها disable

            //            //------------------------------------
            //#nullable disable // دي بتساعدني اني اشيل ال warning من مناطق معينه
            //            string name02 = null;
            //#nullable enable
            //            //------------------------------------

            //            string name03 = null!;// null-forgiving operator
            #endregion

            #region Null-Conditional | Propagation operato

            #region Example01
            //Employee employee = new Employee();

            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.Department.Name);// NullReferenceException
            ////هيروح على department هيلاقيها null مش هيلاقي object في heap

            //solve problem 
            //Employee employee02 = new Employee()
            //{
            //    Name = "Mahmoud",
            //    Id = 22,
            //    Department = new Department()
            //    {
            //        Name = "Computer Science",
            //        Id = 11
            //    }
            //};
            ////first way
            //if (employee02 != null && employee02.Department is not null)
            //    Console.WriteLine(employee02.Department.Name);
            ////second way 

            //Console.WriteLine(employee02?.Department?.Name ?? "Not Found");
            //Employee=null -> "Not Found"
            //Department=null -> "Not Found"
            #endregion

            #region Example02
            //int[]? arr = null;


            //Console.WriteLine(arr.Length);// .NullReferenceException
            //هيروح على department هيلاقيها null مش هيلاقي object في heap
            //---------------------------------------------------------------------
            //---------------------------------------------------------------------
            //int lenght = arr?.Length;//error 
            //لإن هو مش هيعرف يعمل implicit طب ليه ضرب error علشان ممكن القيمه ممكن تيجي null وممكن تتكون Value بس لو جت null مش هيعرف يحولها 

            //solve problem

            //first way
            //int? lenght = arr?.Length;

            //second  way
            //int lenght = arr?.Length ?? 0;// Null - Coalescing Operator

            int[] arr02 = { 11, 12, 13 };

            //for(int i = 0; i < arr02?.Length; i++)
            //{
            //    Console.WriteLine(arr02[i]);
            //}//bad performance --> arr02?.Length ب null ولا لا لإن هو كل شويه هيشوف 

            //        بيشوف:
            //            هل arr02 == null؟
            //(ده اسمه "null check")

            //لو مش null → يجيب Length

            //وبعدين يقارن:
            //هل i<arr02.Length؟

            //improve performance

            //if (arr02 is not null)
            //{
            //    for (int i = 0; i < arr02.Length; i++)
            //    {
            //        Console.WriteLine(arr02[i]);
            //    }
            //}
            //improve performance اكتر 
            //if (arr02 is not null)
            //{
            //    int length = arr02.Length;
            //    for (int i = 0; i < length; i++)
            //    {
            //        Console.WriteLine(arr02[i]);
            //    }
            //}

            //بيستخدم المتغير length من stack
            //مش بيروح يجيب.Length من heap كل مرة
            //وده اللي بيخلي الأداء أفضل
            #endregion


            #endregion

            #region Class Library

            //ده بروجكت عادي زي Console 
            //بيكون فيه الكود المشترك يعني مثلا عندي website وعاوز انزله على الموبايل فهاخد الكود المشترك في website بدل مكتب الكود من الاول 
            //مينفعش اعملة Run لإنه اخره dll(il)=> Compilation time
            //------------------------------------------------------------------
            //قبل ماخد reference من ClassLibrary

            //Product P = new Product();//Error لإن لسه معملتش Reference

            //بعد لما عملت Reference 

            //Product P = new Product();
            //P.Name = "Ahmed";
            //Console.WriteLine(P.Name);


            #endregion

            #region User Defined Data Type
            //follow presentation
            // follow folder User Defined Data Type
            #endregion

            #region Access Modifier

            //Access_modifier_A A = new Access_modifier_A();
            ////A.X=1; //Error beacause X IS Private 

            ////A.Y = 10; //Error beacause X IS Internal مينفعش استخدمها خارج ال Project

            //Console.WriteLine(A.Z); //Valid beacause X IS Public 

            //Access_modifier_B B = new Access_modifier_B(); //call constructor


            #endregion

            #region Enums

            #region Example01

            //Person P = new Person();
            //P.name = "Mahmoud";
            //P.id = 10;
            //P.gender = (Gender)1;

            //Console.WriteLine(P.gender);

            ////enum هو int لإن القيم فيه بتتخزن ك ارقام 
            ////لما بتيجي تتخزن في data base بتتخزن في integer
            //int g00 = (int)Gender.Male;
            //Console.WriteLine(g00);

            ////----------------------------------------------------
            ////----------------------------------------------------

            //Grade G01 = Grade.B;
            //if (G01 == Grade.A)
            //    Console.WriteLine("Very Good");
            //else
            //    Console.WriteLine("Bad");

            ////------------------------------------------------------
            ////------------------------------------------------------

            //Grade G02 = (Grade)4;

            //Console.WriteLine(G02 - 1);

            ////----------------------------------------------------------
            ////----------------------------------------------------------

            //Grade G03 = new Grade();
            //Console.WriteLine(G03);//beacause default value 0 => A

            #endregion

            #region Example02
            //Student s1 = new Student()
            //{
            //    Id = 10,
            //    name = "mahmoud",
            //    grade = Grade.A,
            //    gender = Gender.M,
            //    branche = Branches.maadi
            //};
            ////---------------------------------------
            //Student S2 = new Student();

            //Console.WriteLine("Please Enter Info About Student: ");
            ////Id
            //Console.Write("Enter ID : ");
            //bool flagId;
            //int Id;
            //do
            //{
            //    flagId = int.TryParse(Console.ReadLine(), out Id);
            //} while (!flagId);
            //S2.Id = Id;

            ////Name
            //Console.Write("Enter Name : ");
            //S2.name = Console.ReadLine()??"No Name Entered";

            ////Grade
            //Console.Write("Enter Grade : ");
            //bool flagGrade;
            //Grade G01;
            //do
            //{
            //    flagGrade = Enum.TryParse(Console.ReadLine(), out G01);
            //} while (!flagGrade);

            ////Gender
            ////Console.Write("Enter Gender : ");
            ////bool flagGender;
            ////Gender stdGender;
            ////do
            ////{
            ////    flagGender = Enum.TryParse(Console.ReadLine(), out stdGender);
            ////} while (!flagGender);
            ////S2.gender = stdGender;

            //Console.Write("Enter Gender : ");
            //bool flagGender;
            //object stdGender;
            //do
            //{
            //    flagGender = Enum.TryParse(typeof(Gender),Console.ReadLine(), out stdGender);
            //} while (!flagGender);
            //S2.gender = (Gender)stdGender;

            ////Display
            //Console.Clear();
            //Console.WriteLine("ID : {0}",S2.Id);
            //Console.WriteLine("Name : {0}",S2.name);
            //Console.WriteLine("Grade: {0}",S2.grade);
            //Console.WriteLine("Gender : {0}",(Gender)S2.gender);

            #endregion

            #endregion





        }
    }
}
