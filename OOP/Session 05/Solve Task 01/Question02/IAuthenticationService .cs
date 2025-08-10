using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01.Question02
{
    interface IAuthenticationService
    {
        public void AuthenticateUser();
        public void AuthorizeUser();
    }
}
