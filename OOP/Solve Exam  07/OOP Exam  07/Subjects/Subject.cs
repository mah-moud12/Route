using OOP_Exam__07.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Subjects
{
    class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exams.Exam? Exam { get; set; }

        private char AskToStart()
        {
            Console.WriteLine("Do You Want To Start Exam (Y|N)");
            bool flag_Y_N = char.TryParse(Console.ReadLine(), out char Character);
            while (!flag_Y_N || !(Character == 'Y' || Character == 'y' || Character == 'N' || Character == 'n'))
            {
                Console.WriteLine("Try Again Entered.");
                flag_Y_N = char.TryParse(Console.ReadLine(), out Character);
            }
            Console.Clear();
            return Character;
        }
        private int[] RightAnswer()
        {
            int[] arrRights = new int[Exam!.Questions!.Length];

            for (int i = 0; i < Exam?.Questions?.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Exam.Questions[i].Header}   :  Mark[{Exam.Questions[i].Mark}]");
                Console.WriteLine("----------------------");
                Console.WriteLine($"{Exam.Questions[i].Body}?");
                for (int j = 0; j < Exam?.Questions?[i].Answers?.Length; j++)
                {
                    Console.WriteLine($"{j + 1}-{Exam?.Questions?[i].Answers?[j].Text}");
                }
                Console.WriteLine("Please Enter The Answer Id");
                bool flagAnsRight = int.TryParse(Console.ReadLine(), out int AnsRight);
                while (!flagAnsRight || !(AnsRight >= 1 && AnsRight <= 4))
                {
                    Console.Write("Try Again Enter Right Answer Id : ");
                    flagAnsRight = int.TryParse(Console.ReadLine(), out AnsRight);
                }
                arrRights[i] = AnsRight;
                Console.WriteLine();
            }
            Console.Clear();
            return arrRights;
        }
        //  This function asks whether you want to start the exam or not.
        //  collects answers for each question, then evaluates and displays the final mark.
        private void StartExam()
        {
            
            char Character = AskToStart();
            
            if (Character == 'Y' || Character == 'y')
            {
                DateTime startTime = DateTime.Now;
                int[] arrRights = RightAnswer();

                double yourMark = 0;
                double totalMark = 0;
                for (int i = 0; i < arrRights?.Length; i++)
                {
                    Console.WriteLine($"Question {i + 1}: {Exam?.Questions?[i].Body}?");
                    Console.WriteLine($"Right Answer : {Exam?.Questions?[i].Answers?[Exam.Questions[i]!.AnswerRight - 1].Text}");
                    Console.WriteLine($"Your Answer : {Exam?.Questions?[i].Answers?[arrRights[i] - 1].Text}");
                    Console.WriteLine("---------------------");

                    if (Exam?.Questions?[i].Answers?[Exam.Questions[i]!.AnswerRight - 1].Text ==
                        Exam?.Questions?[i].Answers?[arrRights[i] - 1].Text)
                    {
                        yourMark += Exam!.Questions![i].Mark;
                    }
                    totalMark += Exam!.Questions![i].Mark;
                }
                DateTime endTime = DateTime.Now;
                TimeSpan totalTime = endTime - startTime;
                Console.WriteLine($"Your Mark : {yourMark}/{totalMark}");
                Console.WriteLine($"Time => {totalTime.Minutes}:{totalTime.Seconds}");
            }
            else
            {
                Console.WriteLine("Exiting......(^-^)");
            }
        }

        public void SubjectExam()
        {
            Console.WriteLine("Please Enter The Type Of Exam (1 For Practical Or 2 For Final )");
            bool flagTypeOfExam = int.TryParse(Console.ReadLine(), out int NumOfTypeOfExam);
            while (!flagTypeOfExam || !(NumOfTypeOfExam >= 1 && NumOfTypeOfExam <= 2))
            {
                Console.WriteLine("Try Again Enter The Type Of Exam (1 For Practical Or 2 For Final )");
                flagTypeOfExam = int.TryParse(Console.ReadLine(), out NumOfTypeOfExam);
            }
            Exam=NumOfTypeOfExam==1? new Exams.Practical() : new Exams.Final();
            Exam.ShowExam();
            StartExam();
        }
    }
}
