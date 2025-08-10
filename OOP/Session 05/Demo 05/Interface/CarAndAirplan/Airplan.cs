using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface.CarAndAirplan
{
    class Airplan : Vehicle, IMovementOnAir, IMovementOnGround
    {
        // ** Impliment Implicitly **

        //public void Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Left()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Right()
        //{
        //    throw new NotImplementedException();
        //}
        //*********************************************************************************************************
        // Impliment Explicitly علشان ينفد الكل مش يعتبرهم واحد
        void IMovementOnAir.Backward()
        {
            Console.WriteLine("Go to Backward On Air.");
        }

        void IMovementOnGround.Backward()
        {
            Console.WriteLine("Go to Backward On Ground.");
        }

        void IMovementOnAir.Forward()
        {
            Console.WriteLine("Go to Forward On Air.");
        }

        void IMovementOnGround.Forward()
        {
            Console.WriteLine("Go to Forward On Ground.");
        }

        void IMovementOnAir.Left()
        {
            Console.WriteLine("Go to Left On Air.");
        }

        void IMovementOnGround.Left()
        {
            Console.WriteLine("Go to Left On Ground.");
        }

        void IMovementOnAir.Right()
        {
            Console.WriteLine("Go to Right On Air.");
        }

        void IMovementOnGround.Right()
        {
            Console.WriteLine("Go to Right On Ground.");
        }
    }
}
