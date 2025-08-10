using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01
{
    class PushNotificationService : INotificationService
    {
        public void SendNotification(string name, out string message)
        {
            if (name is not null)
                message = $"{name}, You have new message";
            else
                message = $"No Name Please Enter Again";
        }
    }
}
