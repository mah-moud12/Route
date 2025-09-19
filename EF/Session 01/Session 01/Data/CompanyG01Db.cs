using Microsoft.EntityFrameworkCore;
using Session_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01.Data
{
    // يمثل session (context) للتعامل مع قاعدة البيانات CompanyG01_DB
    // EF Core سيستدعي OnConfiguring أثناء إنشاء الكائن لتهيئة الإعدادات،
    // لكن الاتصال الفعلي بقاعدة البيانات لن يتم إلا عند تنفيذ استعلام أو حفظ بيانات.
    class CompanyG01Db : DbContext
    {
        // إنشاء كائن من هذا الكلاس يجهّز الإعدادات، والاتصال الفعلي يتم عند تنفيذ استعلام أو عملية حفظ. => saveChage(); هنا بيحصل  ال Open لل connection 

        public CompanyG01Db():base() 
        {
            
        }
        // OnConfiguring هي المكان الذي نحدد فيه إعدادات الـ DbContext
        // مثل اختيار ((Database Provider) البيانات (SQL Server) ووضع الـ connection string.
        // OnConfiguring هيا بتكون فاضيه فلازم اعمل override عليها علشان احط ال connection string بتاع ال DB اللي هشتغل عليها 
        // DbContextOptionsBuilder ده اللي بيكون شايل connection string بتاع DB اللي هشاتغل عليها 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            // دي مش مستخدمه بس هيا شغالة عادي  
            //optionsBuilder.UseSqlServer("Data Source = . ; initial Catalog = CompanyG01_DB; Integrated Security = true");

            // دي المستخدمه
            optionsBuilder.UseSqlServer("Server = . ; Database = CompanyG01_DB ; Trusted_Connection =true;TrustServerCertificate=true");
        }

        public DbSet<Employee> Employees { get; set; } // ده من غيرو احنا منسواش حاجه هههه يعني اي يعني ده من غيرو هيكون ال UP and Down اللي في ال Migration هيكونو فاضيين 
                                                       // طب يعني اي ال UP اللي في migration ده بيكون فيه التغيرات اللي بتحصل يعني انت عاوز تضيف table ف ال UP يكون فيه اضافة ال table 
                                                       // طب يعني اي down هو بيكون عكس UP يعني لو في اضافة table ال down هيكون فيه حدفة 

        public DbSet<Department> Departments { get; set; } // هو هنا لس Not Migrated علشان اقول ان هو  Migrated لازم اعمل add-maigration شوف slide (14)
        public DbSet<Product> Products { get; set; } 
        //public DbSet<Project> Projects { get; set; } 
    
    }
}
