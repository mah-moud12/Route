using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01.Question02
{
    [Flags]
    enum Role:byte
    {
        User=10,
        Employee=20,
        manager = 30,
        admin =40,
    }
}
