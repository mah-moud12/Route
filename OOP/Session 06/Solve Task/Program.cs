using Solve_Task.Discounts;
using Solve_Task.First_Project;
using Solve_Task.Second_Program;
using System.Globalization;

namespace Solve_Task
{

    internal class Program
    {
        static void ProcessTypeUser(UserAfterDiscount userAfterDiscount)
        {
            Discount discount1 = userAfterDiscount.GetDiscount(userAfterDiscount.SpecificUser);
            Console.WriteLine(userAfterDiscount.Name);
            if(userAfterDiscount.SpecificUser!=SpecificUser.GuestUser)
                Console.WriteLine($"Price After Discount : {discount1.CalculateDiscount(2000, 3)}");
            else
                Console.WriteLine($"No Discount Price is  : {discount1.CalculateDiscount(2000, 3)}");
        }

        static void Main(string[] args)
        {
            #region First Project
            //Point3D P = new Point3D(10,20,30);
            //Console.WriteLine(P);
            ////************************************
            //Point3D P1 = new Point3D();
            //Point3D P2 = new Point3D();

            #region Enter P1

            //bool flagP1X, flagP1Y, flagP1Z;
            //int xP1, yP1, zP1;
            //int c1 = 0;
            //do
            //{
            //    if (c1 == 0)
            //        Console.Write("Enter P1 X Number : ");
            //    else
            //        Console.Write("Try Enter P1 X Number : ");
            //    flagP1X = int.TryParse(Console.ReadLine(), out xP1);
            //    c1++;
            //} while (!flagP1X);
            //c1 = 0;
            //P1.X = xP1;
            ////**********************************************************************
            //do
            //{
            //    if (c1 == 0)
            //        Console.Write("Enter Y Number : ");
            //    else
            //        Console.Write("Try Enter Y Number : ");
            //    flagP1Y = int.TryParse(Console.ReadLine(), out yP1);
            //    c1++;
            //} while (!flagP1Y);
            //c1 = 0;
            //P1.Y = yP1;
            ////**********************************************************************
            //do
            //{
            //    if (c1 == 0)
            //        Console.Write("Enter P1 Z Number : ");
            //    else
            //        Console.Write("Try Enter P1 Z Number : ");
            //    flagP1Z = int.TryParse(Console.ReadLine(), out zP1);
            //    c1++;
            //} while (!flagP1Z);
            //c1 = 0;
            //P1.Z = zP1;
            //Console.WriteLine(P1);
            #endregion

            #region Enter P2
            //bool flagP2X, flagP2Y, flagP2Z;
            //int xP2, yP2, zP2;
            //int c2 = 0;
            //do
            //{
            //    if (c2 == 0)
            //        Console.Write("Enter P2 X Number : ");
            //    else
            //        Console.Write("Try Enter P2 X Number : ");
            //    flagP2X = int.TryParse(Console.ReadLine(), out xP2);
            //    c2++;
            //} while (!flagP2X);
            //c2 = 0;
            //P2.X = xP2;
            ////**********************************************************************
            //do
            //{
            //    if (c2 == 0)
            //        Console.Write("Enter P2 Y Number : ");
            //    else
            //        Console.Write("Try Enter P2 Y Number : ");
            //    flagP2Y = int.TryParse(Console.ReadLine(), out yP2);
            //    c1++;
            //} while (!flagP2Y);
            //c2 = 0;
            //P2.Y = yP2;
            ////**********************************************************************
            //do
            //{
            //    if (c2 == 0)
            //        Console.Write("Enter P2 Z Number : ");
            //    else
            //        Console.Write("Try Enter P2 Z Number : ");
            //    flagP2Z = int.TryParse(Console.ReadLine(), out zP2);
            //    c2++;
            //} while (!flagP2Z);
            //c2 = 0;
            //P2.Z = zP2;
            //Console.WriteLine(P2);
            #endregion

            ////************************************
            //Console.WriteLine("-----------------------");
            //Point3D[] arr01 = { P,P1,P2};
            //Array.Sort(arr01);
            //foreach(var item in arr01){
            //    Console.WriteLine(item);
            //}
            ////************************************
            //Console.WriteLine("-----------------------");
            //P2 = (Point3D)P1.Clone();

            //Console.WriteLine($"Hash Code P1 : {P1.GetHashCode()}");
            //Console.WriteLine($"{P1}");

            //Console.WriteLine($"Hash Code P2 : {P2.GetHashCode()}");
            //Console.WriteLine($"{P2}");

            //if(P1==P2)
            //    Console.WriteLine("P1 and P2 Refer the same object");
            //else
            //    Console.WriteLine("P1 and P2 not Refer the same object");


            #endregion


            #region Second Program 

            //Second_Program.Math.Add(20,30);
            //Second_Program.Math.Subtract(20,30);
            //Second_Program.Math.Multiply(20,30);
            //Second_Program.Math.Divide(20,30);

            #endregion


            #region Third Project 
            //Discount discount = new PercentageDiscount(50);
            //Console.WriteLine(discount.Name);
            //Console.WriteLine(discount.CalculateDiscount(100,4));
            //*************************************************************************
            UserAfterDiscount userAfterDiscount = new UserAfterDiscount();
            userAfterDiscount.SpecificUser = SpecificUser.GuestUser;
            ProcessTypeUser(userAfterDiscount);
            //*************************************************************************
            UserAfterDiscount userAfterDiscount1 = new UserAfterDiscount();
            bool flagSpecificUser;
            SpecificUser specificUser;
            int c = 0;
            do
            {
                if(c==0)
                    Console.Write("Enter Type User : ");
                else
                    Console.Write("Try Again Enter Type User : ");
                flagSpecificUser = Enum.TryParse(Console.ReadLine(), out specificUser);
                c++;
            } while (!flagSpecificUser);

            userAfterDiscount1.SpecificUser = specificUser;
            Console.Clear();
            ProcessTypeUser(userAfterDiscount1);




            #endregion




        }
    }
}
