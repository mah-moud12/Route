using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solve_Task.ITI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.ITI.Configrutions
{
    class Stud_CourseConfiguration : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {

            builder.HasKey(SC => new { SC.St_Id, SC.Course_Id });

            builder.HasOne(stud => stud.Student)
                   .WithMany(stud_crs => stud_crs.Student_Courses)
                   .HasForeignKey(stud_crs => stud_crs.St_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(stud => stud.Course)
                   .WithMany(stud_crs => stud_crs.Student_Courses)
                   .HasForeignKey(stud_crs => stud_crs.Course_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
