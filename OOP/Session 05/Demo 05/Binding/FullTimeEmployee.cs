using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Binding
{
    class FullTimeEmployee:Employee
    {
        
        #region Properties
        public decimal Salary { get; set; }
        #endregion

        #region Constructor
        public FullTimeEmployee(int Id,string? Name,int Age,decimal salary):base(Id,Name, Age)
        {
            Salary = salary;
        }
        #endregion


        #region Method
        new public void GetEmployeeType()
        {
            Console.WriteLine("I am Full Time Employee");
        }

        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"Salary = {Salary:c}");
        }
        #endregion


    }
}
