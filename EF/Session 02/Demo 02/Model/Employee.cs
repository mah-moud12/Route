using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Demo_02.Model
{
    
   public class Employee
    {

        public int EmpId { get; set; } 
        public string? Name { get; set; }
     
        public decimal Salary { get; set; }
     
        public int Age { get; set; }
        [Required]
        public required string PhoneNumber { get; set; } // required دي بتمنعني اني مضفش ال phone number في compilation time 
                                                      // بس دي انا لو شلت Data Annotation[Required] هيكون في Db ب Allow Null حتى لو فيه required يعني اللي عاوز اقولة ان required ملهاش علاقه ب DB هيا بس بتفرض عليا اني منساش اضيف phone number  

        public string? EmailAddress { get; set; }
        public string? Password { get; set; }

        [NotMapped]
        public int Deduction { get; set; }

        // Navigation Property [One] 
        // Ef Core : Employee May Manage One Department [ Partial Participation ]
        [InverseProperty(nameof(Department.Manager))]
        public Department? MangeDepartment { get; set; } // لي عملت كده ؟ لان انا عندي في ال business ان ال Employee مش لازم يكون عنده Department
        public Address Address { get; set; } = null!;


        #region Many - One [Mendatory - Mendatory]
        // Navigation Property [One] 
        // Ef Core : Employee Must be Work In a Department [ Total Participation ]

        [InverseProperty(nameof(Department.employees))] // الافضل اللي انا اعمل الحته دي لانها بتوضحلي ان navigation دي تبع انهي Navigation في Department 
        public int empDepartment { get; set; }
        public Department Department { get; set; } = null!; 
        #endregion

        #region Error !!!!!!!!!!!!!!!!!!!!!!!

        // لازم علشان احل المشكلة دي لازم اروح ل Address واحط عليه Data Annotation [OWned] لانه مش فيه PK لو مش عاوز تعملة كده حطلة PK

        //Unable to create a 'DbContext' of type 'CombanyDbContext'. The exception 'The entity type
        //'Address'(((( requires a primary key to be defined)))). If you intended to use a keyless entity type, 
        //call 'HasNoKey' in 'OnModelCreating'. For more information on keyless entity types, 
        //see https://go.microsoft.com/fwlink/?linkid=2141943.' was thrown while attempting to create an instance.
        ////For the different patterns supported at design time,
        //see https://go.microsoft.com/fwlink/?linkid=851728

        #endregion
    }
}
