using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class PrintedBook:Book
    {
        protected internal int PageCount { get; set; }

        public PrintedBook(int PageCount, string Title, string author) : base(Title, author)
        {
            if (PageCount <= 0)
                Console.WriteLine("Invalid Page Count must be positive.");
            else
                this.PageCount = PageCount;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nPageCount : {PageCount}";
        }
    }
}
