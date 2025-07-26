using Demo_02.Encapsulation;
using Demo_02.Enums;

namespace Demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            User U = new User();
            U.Id = 10;
            //الطريقة دي بتاخد مساحه 
            //4 byte
            //U.Permisions[0]=true;//Delete
            //U.Permisions[1]=true;//Execute
            //U.Permisions[2]=true;//Read
            //U.Permisions[3]=true;//Write
            //--------------------------------------

            //Use Enum
            //use 1 byte 

            //U.Id = 10;
            //U.permision = (Permision)1; // Delete                          0 0 0 0 0 0 0 1
            //U.permision = (Permision)15; // Delete, Execute, Read, Write   0 0 0 0 1 1 1 1
            //U.permision = (Permision)10; // Execute, Write                 0 0 0 0 1 0 1 0

            //Console.WriteLine(U.permision);

            ////add permision
            ////Note => لو موجوده هيحدفها لو مش موجوده هيضيفها علشان كده لازم وانا بستخدمه اعمل Check الاول قبل م استخدمها 
            //U.permision = U.permision ^ Permision.Read;
            //Console.WriteLine(U.permision);

            //U.permision ^= Permision.Read;
            //Console.WriteLine(U.permision);

            ////correct use ^
            //if((U.permision & Permision.Read) == Permision.Read)
            //    Console.WriteLine("Is Exist");
            //else
            //    U.permision ^= Permision.Read;

            //Console.WriteLine(U.permision);

            ////ممكن اختصر دا كله في خطوة واحده فقط
            //// Use |
            ////لو موجودة مش هيعمل حاجه لو مش موجوده هيضيفها
            //U.permision |= Permision.Read;
            //Console.WriteLine(U.permision);

            #endregion

            #region Struct

            #region Example01
            //Point p01;//8 byte

            //p01 = new Point();
            ////دي بتختلف عن Class دي مش Reference
            ////New is just for constructor selection that used to initialize p01 attribute
            ////يعني دي بتختار constructor اللي هتبتدي تعمل initialize ل attribute

            //Console.WriteLine(p01.X);
            //Console.WriteLine(p01.Y);
            #endregion

            #region Example02
            //Point p01 = new Point(10,20);

            //Console.WriteLine(p01.X);
            //Console.WriteLine(p01.Y);

            //Point p02 = new Point(30, 40);

            //Console.WriteLine(p02.X);
            //Console.WriteLine(p02.Y);

            //p02 = p01;

            //Console.WriteLine(p02.X);
            //Console.WriteLine(p02.Y);

            //p02.X = 5;
            ////follow presentation
            //Console.WriteLine(p01.X);


            ////هنا هتكون ابطئ نسبيا يعني بشكل غير ملحوظ طب ليه هيا ابطئ علشان ببعتلها object هتروح تمرره :
            ////   ل function WriteLine وبعد متمرره هتروح تحولة 
            ////   ودي اللي بنستخدمها اكتر لأنها اوضح ولو عملت P01 = null دي مش هتطلع معايا Exception فعلشان كده دي افضل
            //Console.WriteLine(p01);
            ////دي اسرع نسبا لإن انت بتبعتلة string على طول 
            //// دي مش بستخدمها كتير لإن لو P01 =null هتطلع معايا Exception علشان بحاول احولها ل string ومفيش حاجه احولها اصلا 
            //Console.WriteLine(p01.ToString());

            ////ال struct مش object بس يقدر يتصرف اكنه Object 

            ////note
            //// الـ struct مش بيدعم الوراثة، فإزاي بيورث من System.Object
            ////    الـ struct مش بيورث من System.Object بالمعنى التقليدي زي الكلاسات. بدل كده، الـ CLR بيوفر دعم خاص للـ struct عشان يقدر يستخدم الدوال الأساسية بتاعة System.Object (زي ToString() و Equals()).
            ////    الـ struct مش بيورث زي الكلاسات (يعني مش هتعرف تخلي struct يورث من struct تاني). لكن C# بيديله "إذن خاص" عشان يستخدم دوال System.Object من غير وراثة حقيقية.
            #endregion


            #endregion

            #region Encapsulation
            //Employee emp = new Employee(10,"Ahmed",6000);
            ////emp.Id = 10;// Set Id Direct By Attribute
            ////Console.WriteLine(emp.Id);// Get Id Direct By Attribute
            ////قبل ال Encapsulation كان فيه 3 مشاكل :
            //// 1 - اي تغير هعملة هيحس بيه العالم الخارجي 
            //// 2 - انا لو حاول امنع  ال set لإن انا عاوز امنع اي حد يعدل فهعمل Id private  صح ماشي بس هيطلعلك مشكلة لإنك مش هتعرف تعمل  get
            //// 3 - مش هتعرف تعمل Validation
            ////      بعمل validation علشان حماية الداتا برضو مثلا هخلي مينفعش حد يدخل قيم سالبة وهكدا

            ////emp.SetName("Ahmed Mohamed EL Sayed ");
            ////emp.SetId(100);
            ////Console.WriteLine(emp);
            ////-----------------------------------------------------
            ////call property

            ////emp.Salary = 20000.00m;
            //Console.WriteLine(emp.Salary);
            //decimal c = emp.Deduction;
            //Console.WriteLine(emp.Deduction);



            #endregion

            #region Indexer

            PhoneNotebook PNB = new PhoneNotebook(3);
            #region Example 01
            PNB.AddPerson(0, "May", 123);
            PNB.AddPerson(1, "Ahmed", 456);
            PNB.AddPerson(2, "Amr", 789);

            //Console.WriteLine(PNB.GetNumber("May"));
            //PNB.SetNumber("May", 1020);

            //Console.WriteLine(PNB.GetNumber("May"));


            PNB.DisplayAllPerson();
            #endregion

            #region indexer

            PNB["Ahmed"] = 22;
            Console.WriteLine(PNB["Ahmed"]);

            for (int i = 0; i < PNB.Size; i++)
            {
                Console.WriteLine(PNB[i]);
            }
            #endregion
            #endregion
        }
    }
}
