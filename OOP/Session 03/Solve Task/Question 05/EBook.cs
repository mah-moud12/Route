using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class EBook:Book
    {
        public decimal fileSize{ get; set; }

        public EBook(decimal fileSize, string Title,string author):base(Title,author)
        {
            if (fileSize <= 0)
                Console.WriteLine("Invalid file size must be positive.");
            else
                this.fileSize = fileSize;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nSize : {fileSize}MB";
        }

    }
}
