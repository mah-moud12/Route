using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class Book
    {

        #region Properties
        protected string? title { get; set; }
        protected string? author { get; set; }
        private Guid ISBN { get; set; }
        #endregion

        #region Constructor
        public Book(string? title, string? author)
        {
            this.title = title;
            this.author = author;
            ISBN = Guid.NewGuid();
        }
        #endregion
        #region method
        public override string ToString()
        {
            return $"Book Info : \nTitle : {title}\nAuthor : {author}\nISBN : {ISBN}"; 
        }

        #endregion
    }
}
