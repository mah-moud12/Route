using Demo_02.Model;
using Microsoft.EntityFrameworkCore; // دي library اللي موجوده في package اللي انا نزلتها وال library دي بيكون فيها class DbContext
//using Common;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Transactions;
using System.Reflection;
namespace Demo_02.Data
{
    class CombanyDbContext : DbContext
    {

        public CombanyDbContext() : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent Api
            //modelBuilder.Entity<Employee>().HasKey(emp => emp.EmpId); // كده انا بقولة ان empId هو ال primary key 

            //// في تلات طرق علشان امسك ال Property 
            //modelBuilder.Entity<Employee>().Property("Name"); // unsafe لان لو فيه error مش هحس بيه 
            //modelBuilder.Entity<Employee>().Property(emp => emp.Name);
            //modelBuilder.Entity<Employee>().Property(nameof(Employee.Name))
            //                                .HasColumnType("VarChar") // دي زي ماكنت بعمل في data Annotation [Column(TypeName ="VarChar")]
            //                                .HasColumnName("EmpName")// دي زي ماكنت بعمل في data Annotation [Column("EmpName")]
            //                                .HasMaxLength(50) // دي زي ماكنت بعمل في data Annotation [MaxLength(50)]
            //                                .IsRequired(false); // دي زي ماكنت بعمل في data Annotation [Required]

            //// الاستفاده من اني اعمل كده هو اني ممكن اعمل اللي بتعملو Data Annotation
            //modelBuilder.Entity<Department>(D /*D=>EntityTypeBilder*/  =>
            //{
            //    D.ToTable("Departments", "Sales"); // ده هيكون اسمها في DB وده بدل معمل Dbset<Department> 
            //                                       // Sales دي Schema لو مفيش Schema بالاسم ده هو هيعملها create  طب لو فيه مش هيعمل حاجه 

            //    D.HasKey(Dept => Dept.DeptId); // حددت ال Key

            //    D.Property(Dept => Dept.DeptId)
            //        //.ValueGeneratedNever() // كده انا بشيل ال Identity
            //        .UseIdentityColumn(10, 10); // لو عاوز اضيف Identity



            //    D.Property(Dept => Dept.DeptName)
            //     .HasColumnName("DepartmentName")
            //     .HasDefaultValue("HR")
            //     .HasMaxLength(50)
            //     .IsRequired(false);

            //    D.Property(Dept => Dept.DateOfCreation)
            //        .HasAnnotation("DataType", "Date") // هنا انا بتحكم في طريقة العرض =>دي زي ماكنت بعمل في data Annotation [DataType(DataType.Date))]
            //                                           // وبرضو بتوريني انه ينفع اكتب Data Annotation 
            //      //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now));// هنا انا بحول من DateTime ل DateOnly لاني مش عاوزه يعرضلي الوقت 
            //                                           // الطريقة دي وحشة لان انا مثلا لو عملت اضافة ل Department انهارده هيضيفة بتاريخ انهارده ولو جيت ضفت department بكرا هيعملو بتاريخ امبارح لان هو اتثبت من اول مرة 
            //        .HasDefaultValueSql("GetDate()"); // هنا ال function هتتنفد وقت لما اعمل action عليها يعني لو ضفت Department انهارده هيضيفه بتاريخ انهارده ولو جيت ضفت Department بكراهيضيفه بتارخ بكرا 

            //    D.Ignore(Dept => Dept.Serial);// كده ال Property بتاعت Serial مش هتتضاف في DB
            //    /**************************************/
            //    //D.Property(Dept => Dept.Serial);
            //    //.HasComputedColumnSql //  كده ال Property بتاعت Serial مش هتتضاف في DB 


            //});
            #endregion

            #region Configration Api 
            // هي تحسين ل Fluent Api



            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigration());
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigration());

            // نظمتلي الدنيا اكتر حياتي بقت احسن بكتير انا فعلا حسيت بالتغير

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());// كده هينفد اي كلاس ب Implement IEntityTypeConfiguration 
            #endregion


            #region One - One 
            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.MangeDepartment)
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(D => D.DeptManagerId)
            //            .OnDelete(DeleteBehavior.NoAction)
            //            .IsRequired(true);
            //***********************************************
            //// Another Way
            //modelBuilder.Entity<Department>()
            //    .HasOne(d => d.Manager)
            //    .WithOne(e => e.MangeDepartment)
            //    .HasForeignKey<Department>(D => D.DeptManagerId)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);
            //***********************************************
            // Another Way غلط ابقى شوف الصح 
            //modelBuilder.Entity<Employee>()
            //            .HasOne<Department>()
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(d => d.DeptManagerId)
            //            .OnDelete(DeleteBehavior.Cascade); 
            #endregion


            #region Many - Many 
            //modelBuilder.Entity<Student>()
            //    .HasMany(Stud => Stud.Courses)
            //    .WithMany(Crs => Crs.Students)
            //    .UsingEntity(RT => RT.ToTable("Mahmoud"));


            modelBuilder.Entity<Stud_Course>()
                        .HasKey(SC => new { SC.StudId, SC.CrsId });

            modelBuilder.Entity<Student>()
                .HasMany(Stud => Stud.Stud_Courses)
                .WithOne(SC => SC.Student)
                .HasForeignKey(SC => SC.StudId)
                .IsRequired(true);

            modelBuilder.Entity<Course>()
                .HasMany(Crs => Crs.Stud_Courses)
                .WithOne(SC => SC.Course)
                .HasForeignKey(SC => SC.CrsId); 
            #endregion

        }
        protected override void OnConfiguring(DbContextOptionsBuilder sql)
        {
            //sql.UseSqlServer("Data Source = .; Initial Catalog = CompanyTest; Integrated security= true;TrustedServerCertificate=true");
            sql.UseSqlServer("Server = .;Database = CompanyTest;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Department> Departments { get; set; }

        #region Error !!!!!!!!!!!!!!!!!!!!!!
        // error ده طلع لانه بيقولك مفيش Key في Department  طب اي الحل وانا مش معايا Class ده انا مجرد معايا reference بس من il مش معايا ال source code  يبقى مينفعش اعمل هنا Data Annotation بس ينفع اعمل Fluent Api وده اللي بميزه لانة ظهر لحل المشكلة دي 
        //هام هام !!!!!!!!!!!!!!!!!!!!!
        //Unable to create a 'DbContext' of type 'CombanyDbContext'. The exception 'The entity type 'Department' (((requires a primary key))))to be defined. 
        //If you intended to use a keyless entity type, call (((('HasNoKey'))))) in 'OnModelCreating'.
        //For more information on keyless entity types, see https://go.microsoft.com/fwlink/?linkid=2141943.'
        //was thrown while attempting to create an instance.For the different patterns supported at design time,
        //see https://go.microsoft.com/fwlink/?linkid=851728PM> 

        //******************************************************** 
        #endregion


        //شوف ال sql server profiler 

    }
}
