using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01.Model
{
    // Model - Entity - Domain Model - POCO Class [Plain Old CLR Object]
    // Properties Only مينفعش اكتب جواه حاجه غير ال properties 
    [Table("Hamada")] // كده لما يجي يتحول الكلاس ده يتحول table في DB هيكون اسمه hamada مش هيكون Employees زي منا  عامل في Dbset 
    class Employee
    {
        #region By Convention
        ////Ef=> public numeric property named as [Id - EmployeeId] => PK  ---- هنا ال EF هتروح تدور على public numeric بالاسامي دي Id - ClassNameId وتعتبره هو primary key 
        //// Automaticly Assumed to be primary PK of Table هو لوحده هيعتره PK
        //// Id Mapped To int PK with  Identity  Constrain(1,1)
        //public int Id { get; set; }
        //// Nullable Ref Type
        //// String? Is Mapped to nvarchar(max) Allow Null => الكلام ده من اول (.net 6.0) فيما فوق  
        //// String Is Mapped to nvarchar(max) Not Allow Null => الكلام ده من اول (.net 5.0) وانت نازل بقى
        //public string? Name { get; set; }
        //// value type Not null
        //// decimal is mapped to decimal(18,2) not allow null => decimal(18,2) ده ال defualt سواء هنا او في sql 
        //// decimal? Allow null
        //public decimal Salary { get; set; }
        //// value type Not null
        //// int is mapped to int not allow null
        //// int? Allow null
        //public int Age { get; set; }

        #region Notes 
        // انا هنا في By Convention معملتش اي حاجه علشان افهمه هو فهم لوحده 
        #endregion

        #endregion



        #region Data Anotation
        // Id Mapped To int PK with  Identity  Constrain(1,1)
        [Key]
        public int EmpId { get; set; } // EF كده مش هيفهم by convention  لانه لا هو [Id - ClassNameId] فلازم احددلة ب Data Anotation => [Key]
        // Nullable Ref Type
        [Column("EmpName", TypeName = "varchar")] // هنا انا اتحكمت في ان اسمه في ال DB هيكون اسمه EmpName وبرضو بدل مايكون by default nvarchar(max) انا خليتها varchar(1)
        [MaxLength(50, ErrorMessage = "Name Must be less than 51")] // هنا ال maxLength هتتحول ل varchar(50) في DB اما Error Message مجرد validation بس مش هتتحط في DB
        [MinLength(3, ErrorMessage = "Name Must be More than 2")] // هنا minLength مش هتتحول في DB هيا برضو مجرد validation وبرضو هيا بتمنعك انك تدخل Name ال Length بتاعه اقل من 3
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name Must be less than 51 and  More than 2")] // min and Error message مش هيتحولو في DB
        [Length(3, 50)] // نفس الفكرة min مش هيتحول في DB
        public string? Name { get; set; }
        // value type Not null
        // decimal? Allow null
        [Column("EmpSalary", TypeName = "decimal(10,2)")]// هنا انا اتحكمت في ان اسمه في ال DB هيكون اسمه EmpSalary وبرضو بدل مايكون by default decimal(18,2) انا خليتها decimal(10,2)
        public decimal Salary { get; set; }
        // value type Not null
        // int is mapped to int not allow null
        // int? Allow null
        [Range(22, 50)]
        [AllowedValues(22, 26, 30, 34, 38)] // دي هتكون ال value اللي مسموحلك اللي انت تدخلها 
        [DeniedValues(24, 27, 29, 31, 33)] // دي هتكون ال value اللي مش مسموحلك اللي انت تدخلها 
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)] // To Display Value As Phone Number
                                         // يعني ال value اللي جاية من Db عاوزها تتطبع على شكل phone number
        [Phone] // لازم اللي تدخلو يكون Phone 
                // To Check Value Before Store In DB
        public int PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]// To Display Value As Email Address
                                         // يعني ال value اللي جاية من Db عاوزها تتطبع على شكل Email Address
        [EmailAddress] // لازم اللي تدخلو يكون email 
                       // To Check Value Before Store In DB
        public int EmailAddress { get; set; }
        [DataType(DataType.Password)]
        public int Password { get; set; }
        [NotMapped] // ده مش هيخلي ال Deduction يتحول ل table في DB يعني property بتتحسب من property تانية 
        public int Deduction { get; set; } 
        #endregion
    }
}
