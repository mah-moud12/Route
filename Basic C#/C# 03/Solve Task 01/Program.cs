using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Solve_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //Console.Write("Please Enter The Number: ");
            //bool FlagNum = int.TryParse(Console.ReadLine(), out int num);
            //Console.Clear();
            //Console.WriteLine($"Your Number is : {num}");
            #endregion

            #region 02
            //Console.Write("Enter the Number: ");
            //string Number = Console.ReadLine();
            //bool flagNumber = int.TryParse(Number, out int res);

            //if(flagNumber)
            //    Console.WriteLine("the number is : {0}",res);
            //else
            //    Console.WriteLine("The number you entered is not correct");

            #endregion

            #region 03
            //float floatNumber01 = 10.1f;
            //float floatNumber02 = 10.2f;
            //float res = (floatNumber01 + floatNumber02);
            //Console.WriteLine("The Result Sum is : {0} + {1} = {2}",floatNumber01,floatNumber02,res);
            #endregion

            #region 04
            //Console.WriteLine("Please Enter The Full Name: ");
            //string sentenceFullName = Console.ReadLine();
            //int c = 1;
            //string FName = "", LName = "";
            //sentenceFullName = sentenceFullName.Trim();

            //if (sentenceFullName.Length != 0)
            //{
            //    for (int i = 1; i < sentenceFullName.Length - 1; i++)
            //    {
            //        if (sentenceFullName[i] == ' ' && (sentenceFullName[i + 1] != ' ' && sentenceFullName[i - 1] != ' '))
            //            c++;
            //        else if (sentenceFullName[i] == ' ' && sentenceFullName[i + 1] != ' ')
            //            c++;
            //    }

            //    if (c == 2)
            //    {
            //        int countTemp = 0;
            //        for (int i = 0; i < sentenceFullName.Length; i++)
            //        {
            //            if (sentenceFullName[i] == ' ')
            //            {
            //                countTemp++;
            //                continue;
            //            }

            //            if (countTemp == 0)
            //                FName += sentenceFullName[i];
            //            else if (countTemp > 0 )
            //                LName += sentenceFullName[i];
            //        }

            //        Console.WriteLine("The First Name is : {0}", FName);
            //        Console.WriteLine("The Last Name is  : {0}", LName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try Again Enter Full Name Contain First Name And Last Name.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The Sentence Is Empty Try Again");
            //}

            #endregion

            #region 05
            //int value = 10;
            //int value02 = 20;
            //value = value02;
            //value02 = 30;
            //Console.WriteLine(value);
            //Console.WriteLine(value02);
            #endregion

            #region 06
            //P1 obj01 = new P1();
            //P1 obj02 = new P1();
            //obj01.X = 10;
            //obj02 = obj01;

            //obj01.X = 400;

            //Console.WriteLine(obj01.X);
            //Console.WriteLine(obj02.X);
            #endregion

            #region 07
            //Console.Write("Enter str01: ");
            //string str01=Console.ReadLine();
            //Console.Write("Enter str01: ");
            //string str02= Console.ReadLine();

            //string Result = string.Format("sentence is : {0} {1}",str01,str02);

            //Console.WriteLine(Result);
            #endregion

            #region 08
            //double  amount = Convert.ToDouble(Console.ReadLine());
            //double rate = Convert.ToDouble(Console.ReadLine());
            //double time = Convert.ToDouble(Console.ReadLine());
            //double interest = (amount * rate * time) / 100;

            //string res = $"({amount} * {rate} * {time}) / 100 = {interest}";

            //Console.WriteLine(res);
            #endregion

            #region 09
            //double Weight = Convert.ToDouble(Console.ReadLine());
            //double height = Convert.ToDouble(Console.ReadLine());
            //double BMI = (Weight) / (height * height);
            //string res = $"({Weight}) / ({height} * {height}) = {BMI}";
            //Console.WriteLine(res);
            #endregion

            #region 10
            //bool flagTemp = double.TryParse(Console.ReadLine(), out double temperature);
            //if(temperature<10)
            //    Console.WriteLine("Just Cold");
            //else if (temperature>30)
            //    Console.WriteLine("Just Hot");
            //else
            //    Console.WriteLine("Just Good");
            #endregion

            #region 11
            //Console.Write("Enter the day : ");
            //bool flagDay = int.TryParse(Console.ReadLine(), out int day);

            //Console.Write("Enter the month : ");
            //bool flagMonth = int.TryParse(Console.ReadLine(), out int month);

            //Console.Write("Enter the Year : ");
            //bool flagYear = int.TryParse(Console.ReadLine(), out int Year);

            //string firstFormat = $"Today’s date : {day} , {month} , {Year}";
            //string secondFormat = $"Today’s date : {day} / {month} / {Year}";
            //string thirdFormat = $"Today’s date : {day} - {month} - {Year}";
            //Console.WriteLine(firstFormat);
            //Console.WriteLine(secondFormat);
            //Console.WriteLine(thirdFormat);
            #endregion


            #region 12
            //Console.Write("Enter The Number: ");
            //bool FlagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (FlagNumber)
            //{
            //    if(number%3==0 && number%4==0)
            //        Console.WriteLine("Yes");
            //    else
            //        Console.WriteLine("No");
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");
            #endregion

            #region 13
            //Console.Write("Enter The Number: ");
            //bool FlagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (FlagNumber)
            //{
            //    if (number<0)
            //        Console.WriteLine("Negative");
            //    else
            //        Console.WriteLine("Positive");
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");

            #endregion

            #region 14
            //Console.Write("Enter The Number: ");
            //bool FlagNumber1 = int.TryParse(Console.ReadLine(), out int number1);

            //Console.Write("Enter The Number: ");
            //bool FlagNumber2 = int.TryParse(Console.ReadLine(), out int number2);

            //Console.Write("Enter The Number: ");
            //bool FlagNumber3 = int.TryParse(Console.ReadLine(), out int number3);

            //if(FlagNumber1 && FlagNumber2 && FlagNumber3)
            //{
            //    int max = number1, min = number1;
            //    //maximum
            //    if (number2 > max)
            //        max = number2;
            //    if (number3 > max)
            //        max = number3;

            //    //minimum
            //    if (number2 < min)
            //        min = number2;
            //    if (number3 < min)
            //        min = number3;

            //    Console.WriteLine("The maximum is : {0}",max);
            //    Console.WriteLine("The minimum is : {0}", min);
            //}
            //else
            //    Console.WriteLine("Try again enter the numbers.");
            #endregion

            #region 15
            //Console.Write("Enter The Number: ");
            //bool FlagNumber = int.TryParse(Console.ReadLine(), out int number);
            //if (FlagNumber)
            //{
            //    if (number % 2== 0)
            //        Console.WriteLine("Even");
            //    else
            //        Console.WriteLine("Odd");
            //}
            //else
            //    Console.WriteLine("Try again enter the number.");

            #endregion

            #region 16
            //Console.Write("Enter The Number: ");
            //char character = Convert.ToChar(Console.ReadLine());

            //if(character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("Consonant");

            #endregion

            #region 17
            //Console.Write("Enter The month: ");
            //bool FlagNumber = int.TryParse(Console.ReadLine(), out int numberOfMonth);
            //if (FlagNumber)
            //{
            //    switch(numberOfMonth)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("31");
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("30");
            //            break;
            //        case 2:
            //            Console.WriteLine("28 or 29");
            //            break;
            //        default:
            //            Console.WriteLine("Please enter a number between 1 and 12.");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Try again enter the month.");

            #endregion


        }
    }
}
