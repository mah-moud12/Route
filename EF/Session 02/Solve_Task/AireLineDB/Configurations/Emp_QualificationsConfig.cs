using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solve_Task.AireLineDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Configurations
{
    class Emp_QualificationsConfig : IEntityTypeConfiguration<Emp_Qualification>
    {
        public void Configure(EntityTypeBuilder<Emp_Qualification> builder)
        {
            builder.HasKey(Emp_Qua => new { Emp_Qua.Emp_Id, Emp_Qua.Qualification });
        }
    }
}
