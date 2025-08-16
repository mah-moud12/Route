using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_06.Built_In_Interface
{
    class Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
       
        public Employee()
        {

        }
        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            // + : this.Salary > other.Salary 
            // - : this.Salary < other.Salary 
            // 0 : this.Salary = other.Salary 
            //if (Salary > other?.Salary)
            //    return 1;
            //else if (Salary < other?.Salary)
            //    return -1;
            //else
            //    return 0;

            return Salary.CompareTo(other?.Salary);
        }
    }
}
