using Microsoft.EntityFrameworkCore.Migrations;
using Session_01.Data;

namespace Session_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Instance From CompanyG01Db
            //CompanyG01Db companyG01Db = new CompanyG01Db();

            //try
            //{
            //    // some code 
            //}
            //finally
            //{
            //    companyG01Db.Dispose(); // Close Connection 
            //}

            // الصياغة المختصرة (syntax sugar):
            // using يتحول داخليًا إلى try/finally 
            // عند نهاية البلوك يُستدعى Dispose تلقائيًا.
            //using (CompanyG01Db companyG01Db = new CompanyG01Db())
            //{
            //    // some sugare 
            //}

            //// الصياغة المختصرة (syntax sugar):
            //// using يتحول داخليًا إلى try/finally 
            //using (CompanyG01Db companyG01Db = new CompanyG01Db()) ; 
            #endregion

            #region EnsureDeleted and EnsureCreated
            //CompanyG01Db dbContext = new CompanyG01Db();
            ////dbContext.Employees; // ده لو عاوز استخدم ال table 
            ////******************************************************************

            //// EnsureCreated & EnsureDeleted:
            ////  * EnsureDeleted(): بيمسح قاعدة البيانات كلها (الجداول + البيانات).
            ////  * EnsureCreated(): بيشيك لو قاعدة البيانات مش موجودة → يعملها ويعمل الجداول.
            ////      - لو قاعدة البيانات موجودة بالفعل → مش بيعمل أي تغيير.
            ////  * في التطوير بنستخدم الاتنين مع بعض:
            ////        dbContext.Database.EnsureDeleted();
            ////        dbContext.Database.EnsureCreated();
            ////    - النتيجة: نمسح قاعدة البيانات القديمة وننشئ واحدة جديدة نظيفة من الصفر.

            //dbContext.Database.EnsureCreated();
            //dbContext.Database.EnsureDeleted(); // اللي بيحصل في ال sql => DROP DATABASE [اسم_القاعدة]; 
            #endregion

            #region Migration 
            // Migrations:
            //  * EF Core بيعمل Snapshot (زي لقطة شاشة) للـModel بتاعك (الجداول + الأعمدة + constraints).
            //  * كل Migration جديدة بتقارن Snapshot القديم بالـModel الحالي، وتولّد SQL للتغييرات فقط
            //    (تضيف الجديد من غير ما تمسح القديم أو تضيع الداتا).

            // Add - Migration - Name "InitialCreation" - Context "CompanyG01Db" - OutputDir "Data/Maigration"
            //   *  - Name "اسم ال Migration"
            //   *  - Context "اسم ال Dbcontext"
            //   * - OutputDir "كده انا بتحكم في انهي فولدر هيتخزن "

            // مش مجرد اللي انت عملت migration يبقى خلاص كده سمعت في DB لا هيا بتكون فيها شكل ال table هيكون عامل ازاي في الداتا بيز بس يعني هيا لسه not applay
            // طب علشان اعمل applay لل Up لازم استخدم command => Update-Database كده ال UP هيتنفد وهيسمع في DB والدنيا هتبقى فل الفوللي وي ودي ياغالي  
            // Drop-Database ده كده هيعمل مس للداتا بيز كلها وهيمسحها من SQL برضو 
            #endregion 



        }
    }
}
