using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05.Binding
{
    class Employee
    {

        #region Properties 
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Employee(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        #endregion

        #region Method
        public void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");
        }
        virtual public void GetEmployeeData()
        {
            Console.WriteLine($"Data : Id = {Id}\nName = {Name}\nAge = {Age}");
        }
        #endregion

    }
}
