using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02
{
    class User
    {
        public int Id { get; set; }
        //public bool[]? Permisions { get; set; } = new bool[4];//4 byte
        public Permision permision { get; set; }// 1 byte


    }
}
