using Solve_Task.Q05;
using System;
using System.Collections;
using System.Collections.Specialized;

namespace Solve_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Range01<char> range = new Range01<char>('A', 'D');

            //if (range.IsInRange('B'))
            //    Console.WriteLine("OK");
            //else
            //    Console.WriteLine("NO");

            //int len = range.Length();
            //Console.WriteLine($"Lenght => {len}");
            #endregion

            #region Q02
            //List<string> strings = ["Mahmoud", "Mohamed", "Yousef"];
            //ReverseList<string>.RverseArrayList(strings);
            //foreach (var item in strings)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Q03
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //numbers = EvenNumbers.ListOfEvenNumbers(numbers);
            //foreach (var item in numbers)
            //    Console.Write($"{item} "); 
            #endregion

            #region Q04
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(7);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(5);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(7);
            //fixedSizeList.Add(8);

            //fixedSizeList.Display();

            //Console.WriteLine(fixedSizeList.GetElement(2)); 
            #endregion

            #region Q05
            string str = "MMaahmoud";
            char first = FindFirstNonReapeted.FirstCahracterNonReapted(str);
            Console.WriteLine(first); 
            #endregion


        }
    }
}
