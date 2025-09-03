using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    internal delegate Book FPtr( Book book);
    class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist,FPtr fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
                Console.WriteLine("=========================");
            }
        }
    }
}
