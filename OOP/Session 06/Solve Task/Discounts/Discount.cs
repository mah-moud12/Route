using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Discounts
{
    abstract class Discount
    {
        public abstract string Name{ get;  }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}
