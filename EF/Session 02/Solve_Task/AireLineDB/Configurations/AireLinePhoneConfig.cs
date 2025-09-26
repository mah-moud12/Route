using Microsoft.EntityFrameworkCore;
using Solve_Task.AireLineDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Configurations
{
    class AireLinePhoneConfig : IEntityTypeConfiguration<AireLinePhones>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AireLinePhones> builder)
        {
            builder.HasKey(air => new { air.AL_Id, air.Phone });
        }
    }

}
