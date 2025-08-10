using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Binding
{
    class ParttimeEmployee:Employee
    {
        #region Properties 
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
        #endregion

        #region Constructor
        public ParttimeEmployee(int Id, string? Name, int Age, decimal hourRate, int countOfHours) : base(Id, Name, Age)
        {
            HourRate = hourRate;
            CountOfHours = countOfHours;
        }
        #endregion

        #region Method
        new public void GetEmployeeType()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"Hour Rate = {HourRate}\nCount Of Hours = {CountOfHours}");
        }

        #endregion
    }
}
