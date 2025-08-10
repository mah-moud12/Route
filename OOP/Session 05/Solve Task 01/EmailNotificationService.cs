using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01
{
    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string email, out string message)
        {
            if (email is not null && email.Contains('@'))
                message = $"Hello, {email.Split("@")[0]}";
            else
                message = "No Email Please Enter Again";
        }
    }
}
