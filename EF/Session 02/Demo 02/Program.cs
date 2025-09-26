using Demo_02.Data;
using Demo_02.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CombanyDbContext dbContext = new CombanyDbContext(); // لو سبتها كده لازم انا اللي اقفل ال Connection => try - finally

            using CombanyDbContext dbContext = new CombanyDbContext();

            #region Add
            //// Enum QueryTrackingBehavior :
            ////     * TrakAll
            ////     * No Traking 

            ////dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;// كده انا بشغل ال Change Tracking بس هو By Default بيكون شغال 
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // كده انا وقفت ال Change Tracking يعني اي تغير اعملو وجيت اشوف ال state هتكون ديما Detached
            //Employee employee = new Employee()
            //{
            //    //EmpId=1, // عليه Identity
            //    Name = "Mahmoud",
            //    EmailAddress = "maboyousef681@gmail.com",
            //    Password = "839189138",
            //    Age = 23,
            //    Salary = 3000,
            //    PhoneNumber = "0114167200",

            //};
            //Console.WriteLine("Before Added Local.");
            //Console.WriteLine(dbContext.Entry<Employee>(employee).State); // Detached
            ////  Enum State Obj:
            ////     *   Detached = هو ملوش علاقة ب DB يعني هو مكانش موجود اصلا
            ////     *   Unchanged = هو موجود في DB بس محصلش عليه اي تعديل
            ////     *   Deleted = هو كان موجود في Db واتمسح 
            ////     *   Added = هو مكنش موجود وبعدين انا ضفتف 
            ////     * اللي بيعرف الحاجات دي ال Change Tracking يعني هو بيعرف علاقة ال obj ب DB يعني ال obj ده انضاف ولا لا او ال Obj حصل عليه اي تغير ولا يعني بختصار اي حاجه تحصل على ال obj بيكون ال change tracking على علم بيها 
            ////     * ال Change Tracking بيكون by default شغال => QueryTrackingBehavior.TrakAll


            ////dbContext.Employees.Add(employee);
            ////dbContext.Add(employee);// هنا انا محددتش ال Dbset هو هيحددها من ال parameter اللي انا بعتهولو
            ////dbContext.Set<Employee>().Add(employee); //هنا انا ضقت من غير ما امسك ال Dbset 

            //////dbContext.Entry<Employee>(employee).State = EntityState.Added; // ممكن اعملها انا 

            ////Console.WriteLine("After Added Local.");
            ////Console.WriteLine(dbContext.Entry<Employee>(employee).State); // Added

            //////// Add Remote
            //////dbContext.SaveChanges();
            //////Console.WriteLine(dbContext.Entry<Employee>(employee).State);  

            #region Note
            //QueryTrackingBehavior.NoTracking بيوقف التتبع بس للكائنات اللي راجعة من الـ DB بالـ Queries، لكن أي كائن تضيفه يدوي بـ Add بيتسجّل في الـ Change Tracker عادي.
            //لازم EF Core يعرف حالة الكائن(Added,Modify...) عشان يولّد SQL صح، فمش هتقدر توقف التتبع وقت الإضافة أو التعديل.
            #endregion

            #endregion

            #region select 
            ////var Emp = dbContext.Employees/*كده معايا الجدول*/.Select(emp => emp.Name).FirstOrDefault();
            ////dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // دي هتتنفد على كل اللي جاي من ال DB وكده الاداء  هيكون ضعيف لاني ب read بس 
            //var Emp = dbContext.Employees.AsNoTracking().FirstOrDefault(emp => emp.EmpId == 1); // No Tracking هتتنفد على السطر ده بس 

            //if(Emp is not null)
            //{
            //    Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // Detached
            //    Console.WriteLine(Emp.Name);
            //}
            #endregion

            #region Update 
            ////dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var Emp = dbContext.Employees./*AsNoTracking().*/FirstOrDefault(emp=>emp.EmpId==1);
            //if (Emp is not null)
            //{
            //    Console.WriteLine("Before Update.");
            //    Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // UnChanged
            //    Console.WriteLine(Emp.Name);

            //    Emp.Name = "Sara"; //  لو فيه No ChangeTracking ساعتها هيعمل Detached يعني حتى لو عملت تغير بال الاسلوب ده وهو No ChangeTracking مش هيسمع في DB
            //    //dbContext.Update(Emp); لو فيه No ChangeTracking ساعتها هيعمل Modified 

            //    Console.WriteLine("After Update.");
            //    Console.WriteLine(Emp.Name);
            //    Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // Modified
            //}
            //else
            //    Console.WriteLine("Not Found");
            //// علشان  تسمع في DB 
            //dbContext.SaveChanges();
            //Console.WriteLine(Emp.Name);
            //Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // UnChanged 

            #endregion

            #region Remove

            //var Emp = dbContext.Employees/*كده معايا الجدول*/.Select(emp => emp.Name).FirstOrDefault();
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // دي هتتنفد على كل اللي جاي من ال DB وكده الاداء  هيكون ضعيف لاني ب read بس 
            //Employee? Emp = dbContext.Employees.FirstOrDefault(emp => emp.EmpId == 10); 
            //if (Emp is not null)
            //{
            //    Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // UnChanged 
            //    Console.WriteLine(Emp.Name);

            //    dbContext.Employees.Remove(Emp);
            //    Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // Deleted

            //    dbContext.SaveChanges();
            //    Console.WriteLine(Emp.Name);
            //    Console.WriteLine(dbContext.Entry<Employee>(Emp).State); // Detached

            //}
            #endregion
        }
    }
}
