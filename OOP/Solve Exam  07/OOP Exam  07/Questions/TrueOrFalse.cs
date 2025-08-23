using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Questions
{
    class TrueOrFalse:Question
    {
        public TrueOrFalse() : base("True | False Question") { }

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

            Answers = new Answer[2];
            Answers[0] = new Answer();
            Answers[1] = new Answer();

            Answers[0].Id = 1;
            Answers[0].Text = "True";
            Answers[1].Id = 2;
            Answers[1].Text = "False";

            Console.WriteLine("Please Enter The Right answer Id (1 For True | 2 For Flase)");
            bool flagRightAns = int.TryParse(Console.ReadLine(), out int rightAns);
            while (!flagRightAns || !(rightAns >= 1 && rightAns <= 2))
            {
                Console.WriteLine("Try Again Enter The Right answer Id (1 For True | 2 For Flase)");
                flagRightAns = int.TryParse(Console.ReadLine(), out rightAns);
            }
            AnswerRight = rightAns;
        }
    }
}
