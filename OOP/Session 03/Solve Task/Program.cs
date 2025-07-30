namespace Solve_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //Employee E01 = new Employee(10, "Mahmoud", (int)SecurityPrivileges.Developer, Gender.Male, SecurityPrivileges.Developer, 4000, DateTime.Parse("7-8-2018"));
            //Console.WriteLine(E01); 
            #endregion

            #region 02
            //Develop D01 = new Develop(7, 8, 2018);
            //Console.WriteLine(D01.NameDayMonthYear());
            #endregion

            #region 03
            //Employee[] emp = new Employee[3];

            //emp[0] = new Employee(
            //    id: 1,
            //    name: "Ahmed",
            //    securityLevel: (int)SecurityPrivileges.DBA,
            //    gender: Gender.Male,
            //    securityPrivileges: SecurityPrivileges.DBA,
            //    salary: 5000,
            //    "07-08-2018"
            //    );

            //emp[1] = new Employee(
            //    id: 2,
            //    name: "Amr",
            //    securityLevel: (int)SecurityPrivileges.guest,
            //    gender:Gender.Male,
            //    securityPrivileges: SecurityPrivileges.guest,
            //    salary:3000,
            //    hireDate:"17-06-2020"
            //    );   


            //emp[2] = new Employee(
            //    id: 3,
            //    name: "Omar",
            //    securityLevel: (int)SecurityPrivileges.security,
            //    gender:Gender.Male,
            //    securityPrivileges: SecurityPrivileges.security,
            //    salary:3000,
            //    hireDate:"02-0333-2017"
            //    );


            //int i = 0;
            //while (i<3)
            //{
            //    if (emp[i].temp)
            //    {
            //        Console.WriteLine(emp[i]);
            //        Console.WriteLine("------------------------");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{emp[i].name} entered Date incorrect Id : {emp[i].id}");
            //        Console.WriteLine("------------------------");
            //    }
            //    i++;
            //}
            #endregion

            #region 04
            //Employee[] emp = new Employee[3];

            //emp[0] = new Employee(
            //    id: 1,
            //    name: "Ahmed",
            //    securityLevel: (int)SecurityPrivileges.DBA,
            //    gender: Gender.Male,
            //    securityPrivileges: SecurityPrivileges.DBA,
            //    salary: 5000,
            //    "07-08-2018"
            //    );

            //emp[1] = new Employee(
            //    id: 2,
            //    name: "Amr",
            //    securityLevel: (int)SecurityPrivileges.guest,
            //    gender: Gender.Male,
            //    securityPrivileges: SecurityPrivileges.guest,
            //    salary: 3000,
            //    hireDate: "17-06-2020"
            //    );


            //emp[2] = new Employee(
            //    id: 3,
            //    name: "Omar",
            //    securityLevel: (int)SecurityPrivileges.security,
            //    gender: Gender.Male,
            //    securityPrivileges: SecurityPrivileges.security,
            //    salary: 3000,
            //    hireDate: "02-0333-2017"
            //    );

            //Employee.SortEmployee(emp, emp.Length);

            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine(emp[i]);
            //}
            //// Boxing => Zero
            //// Unboxing => Zero

            #endregion

            #region 05
            EBook eBooke = new EBook(10.5m, "Cats", "Mahmoud");

            Console.WriteLine(eBooke);

            Console.WriteLine("===================================");
            PrintedBook printedBook = new PrintedBook(124, "Cats", "Mahmoud");
            Console.WriteLine(printedBook);

            // reduce dublicate 
            // It also helps in making maintenance easier because I am not repeating the code.
            // It helps me see other classes and make relation between them. 
            // It helps me to be able to reuse the code.
            #endregion


        }
    }
}
