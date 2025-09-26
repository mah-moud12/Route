using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Model
{
   public class Department
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public DateOnly DateOfCreation { get; set; }
        public int Serial { get; set; }

        // Four Way to FK 
        //public int ManagerId { get; set; } //         <NameOfNavigationProperty>Id 
        //public int ManagerDeptId { get; set; } //     <NameOfNavigationProperty><NameOfPrimaryKey>
        //public int EmployeeId { get; set; } //        <TypeOfNavigationProperty>Id 
        //public int EmployeeDeptId { get; set; } //      <TypeOfNavigationProperty><NameOfPrimaryKey>
        //*************************************************
        //[ForeignKey("Manager")] // بس ده Unsafe       
        [ForeignKey(nameof(Manager))]
        public int DeptManagerId { get; set; } // هو هنا ال EF مش هيفهم By Convention فعلشان افهم ال EF ان ده ال FK 
        // Navigation Property [One] 
        // EF Core : Department Must Has One Employee To Manage it [Total Participation] 
        public Employee Manager { get; set; } = null!; //  null! => لي انا عملت كده علشان انا قولتلو ان ال Employee عمرة ماهيكون ب null
        //*************************************************
        //*************************************************

        #region One - Many [Mendatory - Mendatory]
        // Navigation Property [Many]
        // EF Core : Department Must Has One Employee To Work on [Total Participation] 

        [InverseProperty(nameof(Employee.Department))] // هنا انا بفهمه ان Navigation دي تبع ال Employee.Department
        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>(); // انا  عملت ال ICollection علشان انا مش ضامن انا هعمل List ولا Array ف عملت ICollection علشان انشئ اللي انا عاوزه 



        //public Department()
        //{
        //    employees = new HashSet<Employee>();      
        //}
        #endregion


        #region Error !!!!!!!!!!!!!!!!!!!
        //  ده علشان هو مش قادر يحدد ال FK لان انت حاطط هنا Navigation Property وحاطط في ال Employee Navigation Property فده هو اللي بيعمل المشكلة ف الحل انك تمسح Navigation Property اللي عند اللي انت مش عاوز تحط ال FK عنده او حدد ال Fk بطريقة من الاربعه
        //  
        //Unable to create a 'DbContext' of type 'CombanyDbContext'. 
        //The exception 'The dependent side could not be determined for the one-to-one relationship between 'Employee.MangeDepartment' and 'Department.Manager'. 7
        //To identify the dependent side of the relationship, ((configure the foreign key property)). If these navigations should not be part of the same relationship,
        //configure them independently via separate method chains in 'OnModelCreating'.
        //See https://go.microsoft.com/fwlink/?LinkId=724062 for more details.' 
        //was thrown while attempting to create an instance.For the 
        //different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728 
        #endregion

    }
}
