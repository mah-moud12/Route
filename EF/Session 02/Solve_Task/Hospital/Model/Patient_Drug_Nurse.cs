using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Hospital.Model
{
    [PrimaryKey(nameof(Patient_Id), nameof(Date),nameof(Time))]
    class Patient_Drug_Nurse
    {
        //[ForeignKey(nameof(Nurse))]
        public int Nurse_Number { get; set; }
        //[ForeignKey(nameof(Drug))]
        public int Drug_Code { get; set; }
        //[ForeignKey(nameof(Patient))]
        public int Patient_Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string? Dossage { get; set; }
        public Patient? Patient { get; set; }
        public Drug? Drug { get; set; }
        public Nurse? Nurse  { get; set; }



    }
}
