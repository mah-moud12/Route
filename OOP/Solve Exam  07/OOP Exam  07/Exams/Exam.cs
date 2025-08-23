using OOP_Exam__07.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Exams
{
    class Exam
    {
        
        public Question[]? Questions { get; set; }
        public TimeSpan TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }
        virtual public void ShowExam()
        {

        }
    }
}
