using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Questions
{
    class MCQ:Question
    {
        public MCQ() : base("MCQ Question") { }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);

            Console.Write("Please Enter Question Body : ");
            Body = Console.ReadLine();

            Console.Write("Please Enter Question Mark : ");
            bool flagMark = double.TryParse(Console.ReadLine(), out double markInput);
            while (!flagMark)
            {
                Console.Write("Try Again Enter Question Mark :");
                flagMark = double.TryParse(Console.ReadLine(), out markInput);
            }
            Mark = markInput;

            Console.WriteLine("Choices Of Question");
            Answers = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Please Enter Choice Number {i + 1}");
                string ansChoice = Console.ReadLine()!;
                Answers[i] = new Answer();
                Answers[i].Text = ansChoice;
                Answers[i].Id = i;
            }

            Console.Write("Please Enter Right Answer Id : ");
            bool flagAnsRight = int.TryParse(Console.ReadLine(), out int AnsRight);
            while (!flagAnsRight || !(AnsRight >= 1 && AnsRight <= 4))
            {
                Console.Write("Try Again Enter Right Answer Id : ");
                flagAnsRight = int.TryParse(Console.ReadLine(), out AnsRight);
            }
            AnswerRight= AnsRight;
        }
    }
}
