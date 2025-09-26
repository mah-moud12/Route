using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    [PrimaryKey(nameof(AC_Id),nameof(Route_Id),nameof(Departure))]
    class Aircraft_Route
    {
        [ForeignKey(nameof(Air_Route))]
        public int AC_Id { get; set; }
        [ForeignKey(nameof(Route))]
        public int Route_Id { get; set; }
        public TimeOnly  Departure { get; set; }
        public int AL_Id { get; set; }
        public AireLineDB.Model.AirCraft? Air_Route { get; set; }
        public AireLineDB.Model.Route? Route { get; set; }

    }
}
