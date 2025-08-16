using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Second_Program
{
    class Math 
    {
        public static void Add(decimal X, decimal Y)
        {
            Console.WriteLine($"Sum Two Number : {X + Y}");
        }

        public static void Divide(decimal X, decimal Y)
        {
            if(Y!=0)
                Console.WriteLine($"Divide Two Number : {X / Y}");
        }

        public static void Multiply(decimal X, decimal Y)
        {
            Console.WriteLine($"Multiply Two Number : {X * Y}");
        }

        public static void Subtract(decimal X, decimal Y)
        {
            decimal temp;
            if(Y>X)
            {
                temp = X;
                X = Y;
                Y = temp;
            }
            Console.WriteLine($"Subtract Between Two Number : {X - Y}");
        }
    }
}
