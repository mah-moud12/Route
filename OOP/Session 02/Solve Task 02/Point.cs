using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_02
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double GetDistance(Point p1,Point p2)
        {
            double px = Math.Pow(p2.X - p1.X,2);
            double py = Math.Pow(p2.Y - p1.Y,2);
            double res = Math.Sqrt(px + py);
            return res;
        }
    }
}
