using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Encapsulation
{
    public struct Employee
    {
        #region Attribute
        private int Id;
        private string? Name; 
        #endregion

        #region Constructor
        public Employee(int id, string name)
        {
            Id = id;
            SetName(name);
        }
        public Employee(int id, string? name, decimal empSalary) 
        {
            Id = id;
            SetName(name);
            Salary = empSalary;
        }
        #endregion

        #region Encapsulation

        #region Geter and Seter

        public string GetName()
        {
            return Name;
        }

        public void SetName(string? _name)
        {
            Name = _name?.Length>10 ? _name.Substring(0,10) : _name;
        }
        public int GetId()
        {
            return Id;
        }

        public void SetId(int _id)
        {
            Id = _id;
        }

        #endregion

        #region Property

        #region Full property
        private decimal empSalary;

        public decimal Salary
        {
            get { return empSalary; }

            set
            {
                empSalary = value > 5000 ? 5000 : value;
            }
        }

        //private decimal deduction;
        //read only property
        public decimal Deduction
        {
            get { return empSalary * 0.1m; }
        }


        #endregion

        #region Automatic Property
        //The C# compiler generates private backing fields for these properties behind the scenes
        public decimal age { get; set; }
        #endregion


        #endregion

        #endregion

        #region Method
        public override string ToString()
        {
            return string.Format("Id : {0} , Name : {1}",Id,Name);
        }
        #endregion
    }
}
