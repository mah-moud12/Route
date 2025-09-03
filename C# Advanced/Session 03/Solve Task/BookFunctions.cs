using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class BookFunctions
    {
        public static string GetTitle(Book B) => (B is not null ? B.Title : "No Title");
        public static string GetAuthors(Book? B) => B is not null ? string.Join(", ", B.Authors) : "NO Author";
        public static string GetPrice (Book B) => B is not null ? B.Price.ToString() : "NO Price";
    }
}
