using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Q04
{
    class FixedSizeList<T>
    {
        public T [] arr { get; set; }
        int size;
        int top;
        public FixedSizeList(int capacity)
        {
            size = capacity;
            arr = new T[size];
            top = -1;
        }

        public void Add(T num)
        {
            if (top == size-1)
                Console.WriteLine("Full");
            else
            {
                top++;
                arr[top] = num;
            }
        }

        public T GetElement(int idx)
        {
            return arr[idx];
        }

        public void Display()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
