using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam__07.Questions
{
    class Question
    {
        #region Properties
        public string? Header { get; set; }
        public string? Body { get; set; }
        public double Mark { get; set; }
        public Answer[]? Answers { get; set; }
        public int AnswerRight { get; set; }
        #endregion


        public Question() { }
        public Question(string Header)
        {
            this.Header = Header;
        }

        public virtual void ShowQuestion()
        {

        }
    }
}
