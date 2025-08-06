using Solve_Task.Question_01;
using Solve_Task.Qestion_02;
using System.Numerics;
using Solve_Task.Question_04;
using Solve_Task.Question_05;
using Solve_Task.Part02;
using System.Collections.Specialized;
namespace Solve_Task
{
    internal class Program: Calculator
    {

        static void Main(string[] args)
        {
            #region Part01
            #region 01
            //Program obj = new Program();
            //int result01 = obj.Add(1, 2);
            //double result02 = obj.Add(5.2, 2);
            //int result03 = obj.Add(5, 5, 6);

            //Console.WriteLine($"The Result One: {result01}");
            //Console.WriteLine($"The Result Two: {result02}");
            //Console.WriteLine($"The Result Three: {result03}");
            #endregion

            #region 02
            //Rectangle r = new Rectangle(10);

            //Console.WriteLine(r); 
            #endregion

            #region 03
            //Complex_number C01 = new Complex_number()
            //{
            //    Real = 10,
            //    Img = 20
            //};
            //Complex_number C02 = new Complex_number()
            //{
            //    Real = 20,
            //    Img = 10
            //};

            //Complex_number C03 = C01 + C02;
            //Complex_number C04 = C01 - C02;


            //Console.WriteLine($"Sum : {C03}");
            //Console.WriteLine($"Difference : {C04}");
            #endregion

            #region 04
            //Manager M01 = new Manager();
            //M01.Work();
            #endregion

            #region 05
            //BaseClass B01 = new BaseClass();
            //B01.DisplayMessage();

            //BaseClass B02 = new DerivedClass1();
            //B02.DisplayMessage();

            //BaseClass B03 = new DerivedClass2();
            //B03.DisplayMessage();

            ////solve problem 
            //DerivedClass2 D02 = new DerivedClass2();
            //D02.DisplayMessage();
            #endregion 
            #endregion

            #region 01,02,03,04 part02
            Duration D01 = new Duration(10, 139, 99);
            Console.WriteLine(D01);

            Duration D02 = new Duration(666);
            Console.WriteLine(D02);

            Duration D03 = new Duration(7800);
            Console.WriteLine(D03);
            //----------------------------------------
            //----------------------------------------

            //D4=D1+D2
            Duration D04 = D01 + D02;
            Console.WriteLine(D04);

            //D4 = D1 + 7800
            D04 = D01 + 7800;
            Console.WriteLine(D04);

            //D4=666+D1
            D04 = 666 + D01 ;
            Console.WriteLine(D04);

            //D4 = ++D1(Increase One Minute)
            D04++;
            Console.WriteLine(D04);

            //D4 = --D2(Decrease One Minute)
            D04--;
            Console.WriteLine(D04);


            //D1 = D1 - D2
            D04 = D01 - D02;
            Console.WriteLine(D04);


            if(D01>D02)
                Console.WriteLine("D01 > D02");
            else
                Console.WriteLine("D01 > D02");

            if (D01 <= D02)
                Console.WriteLine("D01 < || = D02");
            else
                Console.WriteLine("D01 > D02");

            //if(D01)
            if (D02)
                Console.WriteLine("Ok");

            DateTime date = (DateTime)D01;
            Console.WriteLine(date);

            #endregion

        }
    }
}
