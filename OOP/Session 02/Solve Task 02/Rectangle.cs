using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_02
{
    struct Rectangle
    {
        double height;
        double width;

        public double Height
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Height is negative.");
                else
                    height = value;
            }
            get
            {
                return height;
            }

        }
        public double Width
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Width is negative.");
                else
                    width = value;
            }
            get
            {
                return width;
            }
        }

        public double Area
        {
            get
            {
                return width * height;
            }
        }
    }
}
