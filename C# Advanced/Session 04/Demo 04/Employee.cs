using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class Employee : IEquatable<Employee> ,IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary = {Salary:C}";
        }

        public bool Equals(Employee? other) // ممكن بدل دي اعمل Override على ال Equal بتاعت Object بس مش هعمل كده علشان دي احسن مفيهاش casting
        {
            return Id == other?.Id && Name==other?.Name && Salary==other?.Salary;
        } // لو عملت Equals دي بس هيضيفه برضو لازم تعمل GetHashCode()

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        public int CompareTo(Employee? other)
        {
            if (Id.CompareTo(other?.Id) == 0)
            {
                if (Name?.CompareTo(other?.Name) == 0)
                    return Salary.CompareTo(other?.Salary);

                return Name?.CompareTo(other?.Name) ?? -1;
            }
            return Id.CompareTo(other?.Id);
        }
    }
}
