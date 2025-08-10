using Solve_Task_01.Question01;
using Solve_Task_01.Question02;

namespace Solve_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //ICircle circle01 = new Circle()
            //{
            //    Radius = 5,
            //};
            //circle01.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle()
            //{
            //    Width = 20,
            //    Height = 30
            //};
            //rectangle.DisplayShapeInfo(); 
            #endregion

            #region 02
            //IAuthenticationService authenticationService = new BasicAuthenticationService()
            //{
            //    UserName = "Mostafe_23",
            //    Password = 123456
            //};
            //authenticationService.AuthenticateUser();
            //Console.WriteLine("-------------------");
            //authenticationService.AuthorizeUser(); 
            #endregion

            INotificationService notificationService = new EmailNotificationService();
            notificationService.SendNotification("mahmoud@gmail.com",out string message);
            Console.WriteLine(message);

            INotificationService notificationService1 = new SmsNotificationService();
            notificationService1.SendNotification("01141647200", out string message02);
            Console.WriteLine(message02);

            INotificationService notificationService2 = new PushNotificationService();
            notificationService2.SendNotification("Mahmoud", out string message03);
            Console.WriteLine(message03);

        }
    }
}
