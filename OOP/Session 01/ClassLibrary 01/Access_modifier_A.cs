using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_01
{
    public class Access_modifier_A
    {
        private int X;
        internal int Y;
        public int Z;
        


        public Access_modifier_A()
        {
            X = 1; // X Is Private [Accessibility withn its scope only]
            Y = 2; // Y Is internal [Accessibility withn its scope and same project]
            Z = 3; // Z Is internal [Accessibility withn its scope and same project and External Project]
        }
    }
}
