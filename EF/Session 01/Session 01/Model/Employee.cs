using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01.Model
{
    // Model - Entity - Domain Model - POCO Class [Plain Old CLR Object]
    // Properties Only مينفعش اكتب جواه حاجه غير ال properties 
    // By Convention
    class Employee
    {
        //Ef=> public numeric property named as [Id - EmployeeId] => PK  ---- هنا ال EF هتروح تدور على public numeric بالاسامي دي Id - ClassNameId وتعتبره هو primary key 
        // Automaticly Assumed to be primary PK of Table هو لوحده هيعتره PK
        // Id Mapped To int PK with  Identity  Constrain(1,1)
        public int Id { get; set; }
        // Nullable Ref Type
        // String? Is Mapped to nvarchar(max) Allow Null => الكلام ده من اول (.net 6.0) فيما فوق  
        // String Is Mapped to nvarchar(max) Not Allow Null => الكلام ده من اول (.net 5.0) وانت نازل بقى
        public string? Name { get; set; }
        // value type Not null
        // decimal is mapped to decimal(18,2) not allow null => decimal(18,2) ده ال defualt سواء هنا او في sql 
        // decimal? Allow null
        public decimal Salary { get; set; }
        // value type Not null
        // int is mapped to int not allow null
        // int? Allow null
        public int Age { get; set; }

        #region Notes 
        // انا هنا في By Convention معملتش اي حاجه علشان افهمه هو فهم لوحده 
        #endregion

    }
}
