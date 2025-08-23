using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_07.Static
{
    class Utilities
    {

        #region Attribute 
        private double piNonStatic; 
        private static double piStatic; 
        private static readonly double piReadOnlyStatic; 
        private readonly double piReadOnly; 
        private const double piConstant=90; 
        #endregion


        #region Properties  Static and non-static 
        public int X { get; set; }
        public int Y { get; set; }

        public double PINonStatic {
            //get { return piNonStatic; }// ده عادي استخدم Non- static جوا Non-static 
            //set { piNonStatic = value; }

            get { return piStatic; } // دا برضو عادي لإن انا ينفع استخدم static جوا non-static
            set { piStatic = value; }

        }   
        
        public static double PIStatic {
            //get { return piNonStatic; }// Error لإن مينفعش استخدم Non- static جوا Static 
            //set { piNonStatic = value; }

            //Solve Problem 
            get { return piStatic; } // دا بقى صح لإن انا استخدمت static att جوا static property
            set { piStatic = value; }

            // note 
            //   * ينفع اكتب جو ال static property حاجتين 
            //       - Constant att
            //       - Static att
        }
        #endregion


        #region Constructor 

        // Object member Constructor  - non-stati
        public Utilities(int X, int Y)

        {
            this.X = X;
            this.Y = Y;
            piStatic = 10;// عادي لانها static وينفع اعمل access ل static جوا non-static
            //piReadOnlyStatic = 20; // Error مينفعش لانها readonly static يعني اقرا بس 
            piNonStatic =30;// عادي لانها non-static وينفع اعمل access ل non-static جوا non-static 
            //piConstant = 30; // Error مينفعش اعدل على Constant Value 

            piReadOnly = 40;// عادي اعمل access ل readonly جو non-static constrauctor
        }


        static Utilities()
        {
            // بيعملي initialize لي اي حاجه static 
            // هو private بس ملوش Access Modifier 
            // مينفعش انا اعملة call ال CLR هو اللي بيعملو Calling automatic في اول استخدام ليه 
            Console.WriteLine("Static");
            piReadOnlyStatic = 30; // ده مكنش ينفع اعمل كده في Object member constructor
            piStatic = 20;

        }
        #endregion



        #region Method Static and non-static 

        // Object member method  - non-static  
        //public int MeterToCM(int value)
        //{
        //    return value * 100;
        //}

        //// Class member method  - Static  
        public static int MeterToCM(int value)
        {
            return value * 100;
        }

        //// Class member method  - Static  
        public static double CalcArea(int Radius)
        {
            return 3.14 * Radius * Radius;
            //return Math.PI * Math.Pow(Radius, 2);
        }
        #endregion

        #region Notes
        // في البدايه قبل مستخدم الكلاس CLR بيعمل Initialize لكل Static 

        // Use Class [Three Cases]:
        //    * create object of class 
        //    * create object -> inhirt from another class
        //    * call static function 
        #endregion
    }

    #region Class 
    class Test : Utilities
    {
        public Test() : base(1, 2)
        {

        }
    }

    static class NAN
    {
        // لازم يكون كل حاجه فيه static 
        // متقدرش تاخد منه reference علشان انت بتستدعي كل حاجه باسم الكلاس مش محتاج تستدعيه ب اوبجكت فعلشان كده مينفعش تاخد منه reference 
        // الخلاصة : مينفعش تاخد منه لا reference ولا object 
    }

    //class  f:NAN
    //{

    //}//  مينفعش حد يورث من الكلاس NAN لإنه Static لان مينفعش اخد اوبجكت منه يشاور على ابنه  
    #endregion

}
