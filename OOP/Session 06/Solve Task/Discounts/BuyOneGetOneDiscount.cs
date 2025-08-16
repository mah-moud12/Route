using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Discounts
{
    class BuyOneGetOneDiscount : Discount
    {
        public override string Name { get { return $" Discount = {50}%"; } }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
                return price / 2 * (quantity / 2);
            return price * quantity;
        }
    }
}
