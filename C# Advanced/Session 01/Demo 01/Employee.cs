using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class Employee:IEquatable<Employee>,IComparable<Employee>
    {
        public int Id{ get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        #region Operator Overloading
        public static bool operator ==(Employee left, Employee right)// هيضرب error لو معملتش operator matching اللي هيا (!=)
        {
            //return ((left.Name == right.Name) && (left.Id == right.Id) && (left.Salary == right.Salary));
            return left.Equals(right);
            // هنا دي لو struct هتقارن بين state وبعضها لانها وارثه من value Type اللي وارث من object طب لي مش بيطب نفس ال behavior بتاع ال object انه يقارن بين reference علشان ال struct وارث من value type وال value type وارثه من ال object وغيرت ال behavior بتاع equals 
            // طب دي لو class هتقارن بين reference وبعضها لانها وارثه من ال object وي واخده behavior بتاعه انها تقارن بين references 
        }
        public static bool operator !=(Employee left, Employee right)// هيضرب error لو معملتش operator matching اللي هيا (!=)
        {
            //return ((left.Name != right.Name) || (left.Id != right.Id) || (left.Salary != right.Salary));
            //return !(left.Equals(right));
            return !(left == right);
        } 
        #endregion


        public override bool Equals(object? obj) // boxing
        {
            #region Unsafe Way Using Explicet Casting
            //Employee? employee = (Employee?)obj;

            //if (employee is not null)
            //{
            //    return ((this.Name == employee.Name) && (this.Id == employee.Id) && (this.Salary == employee.Salary));
            //}
            //else
            //{
            //    return false;
            //} 
            #endregion

            #region Safe Casting Using Is Operator 
            //// الكومبايلر الأول بيعمل check: هل obj من النوع Employee (أو يرث منه). يعني اي بيرث منه
            //if (obj is Employee employee) // obj is Employee employee = Safe pattern matching + implicit cast -> (From C# 7 and up).

            //{
            //    return (this.Id == employee.Id && this.Name == employee.Name && this.Salary == employee.Salary);
            //}
            //else
            //{
            //    return false; // ده هيتحقق لو ال parameter [string , struct , another class , null ,....]
            //} 
            #endregion

            #region  Safe Casting Using As Operator 

            Employee? employee = obj as Employee; // هنا هو هيحاول يعمل casting لو عرف هيعمل casting لو منجحش هيرجع null مش هيرجع exception 
            if(employee is not null)
            {
                return (this.Id == employee.Id && this.Name == employee.Name && this.Salary == employee.Salary);
            }
            else
            {
                return false; // ده هيتحقق لو ال parameter [string , struct , another class , null ,....]
            }
            #endregion

            #region Notes 
            //is مع الـ pattern matching = check + implicit cast في الشرط.
            //as = محاولة cast → بيرجع الكائن أو null.
            #endregion

        }
        #region GetHashCode
        //لازم اعمل برضو override على GetHashCode علشان ميظهرليش warning

        public override int GetHashCode()
        {
            // كده غلط لان ممكن يحصل كده 
            // address-> id = 20 , name=1000 , Salary = 30   => 20 + 1000 + 30 => 1050
            // address-> id = 30 , name=1000 , Salary = 20   => 20 + 1000 + 30 => 1050
            // مع انهم مختلفين بس هيطلعو نفس الناتج ودا غلط 

            //return Id.GetHashCode() + Name?.GetHashCode() ?? 0 + Salary.GetHashCode();

            //solve problrem
            return HashCode.Combine(Id, Name, this.Salary);
        }

        #endregion

        public bool Equals(Employee? other)
        {
            if(other is not null)
            {
                return (this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary);
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(Employee? other)
        {
            return this.Salary.CompareTo(other?.Salary);
        }
    }
}
