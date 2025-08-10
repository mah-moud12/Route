using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01.Question01
{
    class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public double Area { get; set; }
        public int Height { get; set; }
        public void DisplayShapeInfo()
        {
            Area = Width * Height;
            Console.WriteLine($"Rectangle Area = {Area}");
        }
    }
}
