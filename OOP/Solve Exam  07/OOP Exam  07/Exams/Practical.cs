using OOP_Exam__07.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Exams
{
    class Practical:Exam
    {
        
        public override void ShowExam()
        {
            Console.WriteLine("Please Enter The Time For Exam From (30 min to 60 min)");
            bool flagTime = int.TryParse(Console.ReadLine(), out int timeInput);
            while (!flagTime || !(timeInput>=30 && timeInput<=60))
            {
                Console.WriteLine("Try Again Enter The Time For Exam From (30 min to 60 min)");
                flagTime = int.TryParse(Console.ReadLine(), out timeInput);
            }
            TimeOfExam = new TimeSpan(0, timeInput, 0);

            Console.WriteLine("Please Enter The Number Of Questiont");
            bool flagNoQuestion = int.TryParse(Console.ReadLine(), out int NoQuestionInput);
            while (!flagNoQuestion)
            {
                Console.WriteLine("Try Again Enter The Number Of Questiont");
                flagNoQuestion = int.TryParse(Console.ReadLine(), out NoQuestionInput);
            }
            NumberOfQuestion = NoQuestionInput;

            Console.Clear();
            Questions = new Question[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Questions[i] = new MCQ();
                MCQ mCQ = new MCQ();
                mCQ.ShowQuestion();
                Questions[i] = mCQ;
                Console.Clear();
            }
        }
    }
}
