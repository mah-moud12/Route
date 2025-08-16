using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Discounts
{
    class NoDiscount : Discount
    {
        public override string Name
        {
            get
            {
                return $"No Discount";
            }
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity;
        }
    }
}
