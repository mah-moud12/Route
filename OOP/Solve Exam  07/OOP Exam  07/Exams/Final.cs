using OOP_Exam__07.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Exams
{
    class Final:Exam
    {
        
        public override void ShowExam()
        {
            Console.WriteLine("Please Enter The Time For Exam From (30 min to 180 min)");
            bool flagTime = int.TryParse(Console.ReadLine(), out int timeInput);
            while (!flagTime || !(timeInput >= 30 && timeInput <= 180))
            {
                Console.WriteLine("Try Again Enter The Time For Exam From (30 min to 180 min)");
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
            NumberOfQuestion= NoQuestionInput;

            Console.Clear();
            Questions = new Question[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine("Please Enter The Of Type Question (1 For MCQ | 2 For True Or False)");
                bool flagTypeOfQuestion = int.TryParse(Console.ReadLine(), out int NumOfTypeOfQuestion);
                while (!flagTypeOfQuestion || !(NumOfTypeOfQuestion >= 1 && NumOfTypeOfQuestion <= 2))
                {
                    Console.WriteLine("Try Again Enter The Of Type Question (1 For MCQ | 2 For True Or False)");
                    flagTypeOfQuestion = int.TryParse(Console.ReadLine(), out NumOfTypeOfQuestion);
                }
                if (NumOfTypeOfQuestion == 1)
                {
                    Questions[i] = new Question();
                    MCQ mCQ = new MCQ();
                    mCQ.ShowQuestion();
                    Questions[i] = mCQ;
                }
                else
                {
                    Questions[i] = new Question();
                    TrueOrFalse trueOrFalse = new TrueOrFalse();
                    trueOrFalse.ShowQuestion();
                    Questions[i] = trueOrFalse;
                }
                Console.Clear();
            }

        }

    }
}
