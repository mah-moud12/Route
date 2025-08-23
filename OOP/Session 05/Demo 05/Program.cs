using Demo_05.Binding;
using Demo_05.Interface;
using Demo_05.Interface.CarAndAirplan;
using Demo_05.Overriding;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TypeA = Demo_05.Interface.TypeA;
namespace Demo_05
{
    internal class Program
    {
        #region Binding
        //// ده كدا يعتبر غلط لان انا بعمل overload وال overload بغير في behavior حته هنا انا مغيرتش فالحل هنا اني استخدم binding علشان اغير تكرار الكود 
        //public static void ProcessOnEmployee(FullTimeEmployee employee)
        //{
        //    if(employee is not null)
        //    {
        //        employee.GetEmployeeType();// I am Full Time Employee لإن reference هو FullTimeEmployee
        //        employee.GetEmployeeData();// هيروح على اخر override 
        //    }
        //} 

        //public static void ProcessOnEmployee(ParttimeEmployee employee)
        //{
        //    if(employee is not null)
        //    {
        //        employee.GetEmployeeType();// I am Part Time Employee لإن reference هو ParttimeEmployee
        //        employee.GetEmployeeData();// هيروح على اخر override 
        //    }
        //}
        //------------------------------------------------------------------------------------------------------

        //solve proble using Binding 
        public static void ProcessOnEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();// I am Employee لإن reference هو Employee
                employee.GetEmployeeData();// هيروح على اخر override 
            }
        }

        #endregion

        #region Interface
        //منعت ان الكود يعتمد على كلاس بقى بيعتمد على انترفيس 
        public static void PrintFiveStep(ITypeA typeA)
        {
            if(typeA is not null)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(typeA.Current);
                    typeA.GetNext();
                }
                typeA.Reset();
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Binding

            #region Example01
            ////Ref from Parent [Base] => object From Child[Derivd]
            ////الأب ممكن يشاور على الابن او الحفيد  يعني اي كلاس بيورث منه او يشاور على نفسه ههههه
            ////الأب مبيكونش شايف ابنه كلة بيكون شايف الحاجات اللي تخصة بس 
            //Overriding.TypeA TA01 = new Overriding.TypeB(1, 2);
            //TA01.A = 10;// هنا عادي لانها تبعة 
            ////TA01.B = 20;// Invalid لان  ال B مش تبعه تبعه تبع ال child 
            //((Overriding.TypeB)TA01).B = 20;
            //TA01.MyFun01();// Static Polymerphism - Static Binding - Early Binding
            //               // Compilation Time
            //               // I am Base لانه معملش virtual فهيروح على الخاصة بيه 
            //               // Overriding [New]
            //               // Resolve at Compile Time Base on Ref Type 

            //TA01.MyFun02();// Dynamic Polymerphism - Dynamic Binding - Late Binding
            //               // Run Time 
            //               // A = 10   ,   B = 2  علشان فيه virtual فهيروح على اخر override 
            //               // keyword Overriding  
            //               // Resolve at run Time Based on Object type 
            #endregion

            #region Example02
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Mahmoud", 21, 3000);
            //ProcessOnEmployee(fullTimeEmployee);
            //Console.WriteLine("---------------------------------");
            //ParttimeEmployee parttimeEmployee = new ParttimeEmployee(11, "Ahmed", 22, 2.5m, 5);
            //ProcessOnEmployee(parttimeEmployee);
            #endregion

            #region Example03
            //Overriding.TypeA typeA = new Overriding.TypeB(1, 2);
            //typeA.MyFun01();// I am Base
            ////typeA.B = 10;// Invalid لان هيا مش خاصة بيه 
            //typeA.MyFun02();// A = 1   ,   B = 2 --> لان هو راح لقها virtual فهيروح  للي في ال object بس لو الفانكشن اللي في الاوبجكت كان معمولها new بدل override كان هيروح للي تبع reference في الوراثه 
            //***************************************************************************************************
            //Overriding.TypeA typeA = new Overriding.TypeC(1, 2, 3);
            //typeA.MyFun01();//I am Base
            //typeA.MyFun02();//A = 1   ,   B = 2   ,   C = 3
            //***************************************************************************************************
            //Overriding.TypeB typeB = new Overriding.TypeC(1, 2, 3);
            //typeB.MyFun01();//I am Drived.
            //typeB.MyFun02();//A = 1   ,   B = 2   ,   C = 3 --> لان هو راح لقها virtual فهيروح  للي في ال object بس لو الفانكشن اللي في الاوبجكت كان معمولها new بدل override كان هيروح للي قابليها في الوراثه 
            //***************************************************************************************************
            //Overriding.TypeA typeA = new TypeD(1,2,3,4);
            //typeA.MyFun01();//I am Base
            //typeA.MyFun02();//A = 1   ,   B = 2   ,   C = 3 --> هنا راح لقاها virtual فكده هيروح على اخر وحده معملها override فراح لاخر واحده لقاها  new فهيروح لل TypeC علشان هيا اخر واحده معمولها override 
            //***************************************************************************************************
            //Overriding.TypeB typeB = new  TypeD(1, 2, 3, 4);
            //typeB.MyFun01();// I am Drived.
            //typeB.MyFun02();// A = 1   ,   B = 2   ,   C = 3
            //***************************************************************************************************
            //Overriding.TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //Overriding.TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //Overriding.TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //Overriding.TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeA.MyFun02();//A = 1   ,   B = 2   ,   C = 3
            //typeB.MyFun02();//A = 1   ,   B = 2   ,   C = 3
            //typeC.MyFun02();//A = 1   ,   B = 2   ,   C = 3
            //typeD.MyFun02();//A = 1   ,   B = 2   ,   C = 3   ,   D = 4   ,   E = 5 --> هنا جاب الخمسة لان السلسه اتقطعت من  TypeD
            //***************************************************************************************************
            //Notes
            ////قبل الـ Late Binding → الكمبايلر يشتغل على حسب نوع الـ Reference، ولازم تعمل Casting للوصول لسلوك الإبن.
            ////بعد الـ Late Binding → بيشتغل على حسب النوع الفعلي للكائن وقت التشغيل، وبالتالي مفيش داعي للـ Casting.
            //Overriding.TypeA typeA = new Overriding.TypeB(1,2);
            //((Overriding.TypeB)typeA).print();

            #endregion
            #endregion

            #region Interface 

            #region Example01
            //IType01 type = new IType01();// Invalid لان مينفعش اخد اوبجكت من Interface ينفع اخد Reference بس او مينفعش اشاور على حد ينفع اشاور بس على اي كلاس ب implement Interface بتاعي 

            //IType01 type01 = new Type01();
            //type01.MyFun01();
            //type01.X = 10;
            //type01.Print();

            //Type01 type01 = new Type01();
            //type01.MyFun01();
            //type01.X = 10;
            ////type01.Print();// Invalid لان دية مش موجوده في implementation  
            #endregion

            #region Example02
            Interface.TypeA typeA = new Interface.TypeA();
            PrintFiveStep(typeA);

            Interface.TypeB typeB = new Interface.TypeB();
            PrintFiveStep(typeB);
            #endregion

            #region Example03

            //Airplan airPlan = new Airplan();
            //airPlan.Backward();// Invalid لان هو مش عارف يحدد انهي bacward 

            //Solve Problem
            //IMovementOnAir movementOnAir = new Airplan();
            //movementOnAir.Backward();
            //movementOnAir.Forward();
            //movementOnAir.Left();
            //movementOnAir.Right();
            //Console.WriteLine("---------------------------------");
            ////--------------------------------------------------------
            //IMovementOnGround movementOnGround = new Airplan();
            //movementOnGround.Backward();
            //movementOnGround.Forward();
            //movementOnGround.Left();
            //movementOnGround.Right();
            //Console.WriteLine("---------------------------------");
            ////----------------------------------------------------------
            //IMovementOnGround movementOnGround1 = new Car();
            //movementOnGround1.Backward();
            //movementOnGround1.Forward();
            //movementOnGround1.Left();
            //movementOnGround1.Right();
            #endregion

            #endregion




        }
    }
}
