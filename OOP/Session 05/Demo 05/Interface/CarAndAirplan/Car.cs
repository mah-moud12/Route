using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface.CarAndAirplan
{
    class Car : Vehicle, IMovementOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Go to Backward On Ground.");
        }

        public void Forward()
        {
            Console.WriteLine("Go to Forward On Ground.");
        }

        public void Left()
        {
            Console.WriteLine("Go to Left On Ground.");
        }

        public void Right()
        {
            Console.WriteLine("Go to Right On Ground.");
        }
    }
}
