using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface
{
    class TypeA : ITypeA
    {
        public int Current { get ; set ; }

        public void GetNext()
        {
            Current += 2;
        }   
    }
}
