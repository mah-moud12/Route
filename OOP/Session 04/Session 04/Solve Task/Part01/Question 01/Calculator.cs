using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Question_01
{
    class Calculator
    {

        protected int Add(int x, int y)
        {
            return x + y;
        }
        protected int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        protected double Add(double x, double y)
        {
            return x + y;
        }
    }
}
