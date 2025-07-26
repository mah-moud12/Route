using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02
{
    [Flags]
    enum Permision:byte
    {
        //Follow Presentation
        Delete = 1,   // 0 0 0 0 0 0 0 1
        Execute = 2,  // 0 0 0 0 0 0 1 0
        Read = 4,     // 0 0 0 0 0 1 0 0
        Write=8,      // 0 0 0 0 1 0 0 0
    }
}
