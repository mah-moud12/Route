using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class Employee
    {
        #region attribute
        public bool temp=true;
        #endregion


        #region Properties
        public int id { get; set; }
        public string? name { get; set; }
        public int securityLevel { get; set; }
        public decimal salary { get; set; }
        public DateTime hireDate { get; set; }
        public Gender gender { get; set; }
        public SecurityPrivileges securityPrivileges { get; set; }
        #endregion

        #region Constructor
        public Employee(int id,string name, int securityLevel, Gender gender, SecurityPrivileges securityPrivileges
                , decimal salary, string hireDate)
        {
            this.id = id;
            this.name = name;
            this.securityLevel = securityLevel;
            this.gender = gender;
            this.securityPrivileges = securityPrivileges;
            this.salary = salary;

            if(DateTime.TryParse(hireDate,out DateTime HireDate))
            {
                this.hireDate = HireDate;
            }
            else
            {
                this.hireDate = DateTime.Now;
                temp = false;
            }
            
         }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"id = {id}\nName = {name}\nSecurity Level = {securityLevel}\nGender = {gender}\nSecurity Privileges = {securityPrivileges}" +
                $"\nSalary = {salary:c}\nHire Date = {hireDate} ";
        }

        public static void SortEmployee(Employee[] empArr,int len)
        {
            bool flagSwap=true;
            Employee tempDate;

            for (int i = 0; i < len-1; i++)
            {
                for (int j = 0; j < len-i-1; j++)
                {
                    if (empArr[j].hireDate < empArr[j+1].hireDate)
                    {
                        tempDate = empArr[j];
                        empArr[j] = empArr[j+1];
                        empArr[j + 1] = tempDate;
                        flagSwap = false;
                    }
                }
                if (flagSwap)
                    break;
            }
        }


        #endregion
    }
}
