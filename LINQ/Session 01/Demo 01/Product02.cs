using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class Product02
    {
        public long ProductId { get; set; }
        public string? ProductName { get; set; }


        public override string ToString()
          => $"ProductID= {ProductId}, ProductName= {ProductName}";
    }
}
