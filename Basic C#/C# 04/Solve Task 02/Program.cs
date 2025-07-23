using System.Net.Sockets;

namespace Solve_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //Console.Write("Please Enter The Number : ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (flagNumber)
            //{
            //    string str = "";
            //    for(int i = 1; i <= number; i++)
            //    {
            //        str += i;
            //        if (i < number)
            //        {
            //            str += ", ";
            //        }
            //    }
            //    Console.WriteLine(str);
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");
            #endregion

            #region 02

            //Console.Write("Please Enter The Number : ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (flagNumber)
            //{
            //    string res = "";
            //   for(int i = 1; i <= 12; i++)
            //   {
            //        res += $"{number * i} ";
            //   }

            //   Console.Clear();
            //   Console.WriteLine(res);
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");

            #endregion

            #region 03
            //Console.Write("Please Enter The Number : ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (flagNumber)
            //{
            //    string res = "";
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            res += $"{i} ";
            //        }
            //    }

            //    Console.Clear();
            //    Console.WriteLine(res);
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");
            #endregion

            #region 04
            //Console.Write("Please Enter The Number 01 : ");
            //bool flagNumber01 = int.TryParse(Console.ReadLine(), out int number01);

            //Console.Write("Please Enter The Number 02 : ");
            //bool flagNumber02 = int.TryParse(Console.ReadLine(), out int number02);
            //if(flagNumber01 && flagNumber02)
            //{
            //    int res=1;
            //    for (int i = 0; i < number02; i++)
            //    {
            //        res *= number01;
            //    }
            //    Console.WriteLine(res);
            //}
            //----------------------------------------------------------------------
            //----------------------------------------------------------------------
            ////anthor way
            //Console.WriteLine("ss  " + Math.Pow(number01, number02));
            #endregion

            #region 05
            //double avg=0, total=0, percentage=0;
            //for (int i = 0; i < 5; )
            //{
            //    Console.Write("Please Enter The Marks : ");
            //    bool falgnumber = int.TryParse(Console.ReadLine(), out int number);
            //    if (falgnumber && number<=100)
            //    {
            //        total += number;
            //        i++;
            //    }
            //    else
            //        Console.WriteLine("try again enter marks");

            //}
            //percentage = (total / 500) * 100;
            //avg = total / 5;

            //Console.Clear();
            //Console.WriteLine("Total marks : {0}", total);
            //Console.WriteLine("Average Marks  : {0}", avg);
            //Console.WriteLine("Percentage : {0}",percentage);

            #endregion

            #region 06
            //Console.Write("Please enter sentence : ");
            //string sentence = Console.ReadLine()?? "No sentence Entered";
            //string res = "";
            //for(int i = sentence.Length - 1; i >= 0; i--)
            //{
            //    res += sentence[i];
            //}
            //Console.WriteLine("Sentence after reversed : {0}",res);
            #endregion

            #region 07
            //Console.Write("Please Enter The Number : ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (flagNumber)
            //{
            //    int reverse=0,digit;
            //   while (number != 0)
            //    {
            //        digit = number % 10;
            //        reverse = reverse * 10 + digit;
            //        number /= 10;
            //    }
            //    Console.WriteLine("Number after reversed: {0}",reverse);
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");

            //---------------------------------------------------------------------------
            //---------------------------------------------------------------------------

            //anathor way

            //Console.Write("Please Enter The Number : ");
            //bool flagNumber02 = int.TryParse(Console.ReadLine(), out int number02);


            //if (flagNumber02)
            //{
            //    string numberStr = Convert.ToString(number02);
            //    string res = "";
            //    for (int i = numberStr.Length - 1; i >= 0; i--)
            //    {
            //        res += numberStr[i];
            //    }
            //    bool flagReversed = int.TryParse(res, out int numberAfterReverse);
            //    Console.WriteLine("Number after reversed: {0}", numberAfterReverse);

            //}
            //else
            //    Console.WriteLine("Try again enter the number.");
            #endregion

            #region 08
            //Console.Write("Please Enter Start Number : ");
            //bool flagStart = int.TryParse(Console.ReadLine(), out int Start);

            //Console.Write("Please Enter End Number : ");
            //bool flagEnd = int.TryParse(Console.ReadLine(), out int end);

            //if (flagStart && flagEnd)
            //{

            //    for (int i = Start; i < end; i++)
            //    {
            //        bool flag = true;
            //        if (i < 2)
            //            continue;
            //        else
            //        {

            //             for (int j = 2; j < i; j++)
            //              {
            //                if (i % j == 0)
            //                {
            //                    flag = false;
            //                    break;
            //                }
            //              }
            //        }
            //        if(flag)
            //            Console.Write("{0} ",i);
            //    }
            //}
            #endregion

            #region 09
            //int number = 100;
            //string res = "";
            //while (number > 1)
            //{
            //    int reminder = number % 2;
            //    if (reminder == 0)
            //    {
            //        res += "0";
            //    }
            //    else
            //    {
            //        res += "1";
            //    }
            //    number /= 2;
            //}
            //res += "1";
            //string finalResult = "";
            //for (int i = res.Length - 1; i >= 0; i--)
            //{
            //    Console.Write("{0}", res[i]);
            //}
            #endregion

            #region 10
            //Console.Write("x1: ");
            //int.TryParse(Console.ReadLine(), out int X1);
            //Console.Write("y1: ");
            //int.TryParse(Console.ReadLine(), out int Y1);

            //Console.Write("x2: ");
            //int.TryParse(Console.ReadLine(), out int X2);
            //Console.Write("y2: ");
            //int.TryParse(Console.ReadLine(), out int Y2);

            //Console.Write("x3: ");
            //int.TryParse(Console.ReadLine(), out int X3);
            //Console.Write("y3: ");
            //int.TryParse(Console.ReadLine(), out int Y3);

            //if ((Y2 - Y1) * (X3 - X2) == (Y3 - Y2) * (X2 - X1))
            //    Console.WriteLine("The points lie on the same straight line.");
            //else
            //    Console.WriteLine("The points do NOT lie on the same straight line.");
            #endregion

            #region 11
            //int Row = 4, col = 4;
            //string matrix = "";
            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        matrix += i == j ? "1 " : "0 ";
            //    }
            //    matrix += "\n";
            //}
            //Console.WriteLine(matrix);
            #endregion


        }
    }
}
