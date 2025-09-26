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
    class Ins_CourseConfiguration : IEntityTypeConfiguration<Inst_course>
    {
        public void Configure(EntityTypeBuilder<Inst_course> builder)
        {
            builder.HasKey(IC => new { IC.Course_id, IC.Inst_id });

            builder.HasOne(Ins => Ins.Instructor)
                   .WithMany(IC => IC.Inst_Courses)
                   .HasForeignKey(IC => IC.Inst_id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(Ins => Ins.Course)
                   .WithMany(IC => IC.Inst_Courses)
                   .HasForeignKey(IC => IC.Course_id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
