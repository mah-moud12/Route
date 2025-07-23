using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassLibrary_01
{
    public class Access_modifier_B
    {

        public Access_modifier_B()
        {
            Access_modifier_A A = new Access_modifier_A();
            //A.X; //Error beacause X IS Private
            Console.WriteLine(A.Y); //Valid beacause X IS Internal 
            Console.WriteLine(A.Z); //Valid beacause X IS Public 

        }


    }
}
