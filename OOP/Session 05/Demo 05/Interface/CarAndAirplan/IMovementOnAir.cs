using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface.CarAndAirplan
{
    interface IMovementOnAir
    {
        public void Backward();
        public void Forward();
        public void Left();
        public void Right();
    }
}
