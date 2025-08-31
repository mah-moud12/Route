using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class Balanced
    {
        static bool isOpen(char c)
        {
            return (c == '(' || c == '{' || c == '[');
        }

        static bool Open(char open ,char close)
        {
            if (open == '(' && close == ')') return true;
            else if (open == '[' && close == ']') return true;
            else if (open == '{' && close == '}') return true;
            else return false;
        }

        public static bool IsBalanced(string str)
        {

            Stack<char> stack=new Stack<char>();
            if(str?.Length>0)
                for (int i = 0; i < str.Length; i++)
                {
                    if (isOpen(str[i]))
                        stack.Push(str[i]);
                    else
                    {
                        if (stack.Count == 0 || !Open(stack.Peek(), str[i]))
                            return false;
                        stack.Pop();
                    }
                }

            return stack.Count == 0;
        }


    }
}
