using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01
{
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string number, out string message)
        {
            if (number is not null && number[0]=='0' && number[1]=='1')
            {
                switch (number[2])
                {
                    case '0':
                        message = $"Your Code is 1234";
                        break;
                    case '1':
                        message = $"Your Code is 1234";
                        break;
                    case '2':
                        message = $"Your Code is 1234";
                        break;
                    case '5':
                        message = $"Your Code is 1234";
                        break;
                    default:
                        message = $"No Number Please Enter Again";
                        break;
                }
            }
            else
                message = "No Number Please Enter Again";
        }
    }
}
