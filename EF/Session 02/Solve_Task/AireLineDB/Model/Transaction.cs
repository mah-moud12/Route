using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.AireLineDB.Model
{
    class Transaction
    {
        public int Id { get; set; }
        public string? Descriptions { get; set; }
        public int Amount { get; set; }
        public DateOnly Date { get; set; }
        [ForeignKey(nameof(Transaction_AirLine))]
        public int AL_Id { get; set; }
        public AirLine? Transaction_AirLine { get; set; }

    }
}
