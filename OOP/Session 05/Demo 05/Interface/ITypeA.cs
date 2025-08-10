using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Interface
{
    interface ITypeA
    {
        // 1. Signature For Property
        public int Current { get; set; }

        // 2. Signature For Method
        public void GetNext();

        // 3. Default Implemented Method "C# 8.0"
        public void Reset()
        {
            Current = 0;
        }

    }
}
