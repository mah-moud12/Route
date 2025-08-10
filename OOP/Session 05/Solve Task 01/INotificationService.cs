using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01
{
    interface INotificationService
    {
        public void SendNotification(string recipient, out string message);
    }
}
