using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_01.Question02
{
    class BasicAuthenticationService : IAuthenticationService
    {
        #region Attribute
        string[] userNames = { "Mahmoud_74", "Mostafe_23", "Rahma_90", "Sasa_90_90" };
        int[] password = { 123456, 123456, 123456, 123456 };
        bool flag;
        #endregion

        #region Properties
        public string? UserName { get; set; }
        public int Password { get; set; }
        public Role Role { get; set; } 
        #endregion

        public BasicAuthenticationService()
        {
            UserName = null;
            Password = 0;
            flag = false;
        }
        public void AuthenticateUser()
        {
            if (UserName is not null && Password != 0)
                for (int i = 0; i < userNames.Length; i++)
                {
                    if(UserName == userNames[i] && Password == password[i])
                    {
                        flag = true;
                        break;
                    }
                }
            if(flag)
                Console.WriteLine("Sucsess Login");
            else
                Console.WriteLine("Try again enter username and password");
        }
        public void AuthorizeUser()
        {
            if (flag)
            {
                switch (UserName)
                {
                    case "Mahmoud_74":
                        Role = Role.admin;
                        break;
                    case "Mostafe_23":
                        Role = Role.manager;
                        break;
                    case "Rahma_90":
                        Role = Role.Employee;
                        break;
                    default:
                        Role = Role.User;
                        break;
                }
                Console.WriteLine($"UserName: {UserName}\nRole: {Role}");
            }
            else
                Console.WriteLine("You must login first to authorize");
           
        }

        public void LogOut()
        {
            flag = false;
            UserName = null;
            Password = 0;
            Console.WriteLine("Logged out successfully");
        }
    }
}
