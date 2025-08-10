using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01.Question01
{
    class Circle : ICircle
    {
        public int Radius { get; set ; }
        public double Area { get; set ; }

        public void DisplayShapeInfo()
        {
            Area = 3.14159 * (Radius * Radius);
            Console.WriteLine($"Circle Area = {Area}");
        }
    }
}
