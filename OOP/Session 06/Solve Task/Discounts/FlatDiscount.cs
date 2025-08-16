using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Discounts
{
    class FlatDiscount : Discount
    {
        public decimal FixedAmount  { get; set; }
        public FlatDiscount(decimal FixedAmount)
        {
            this.FixedAmount= FixedAmount;
        }
        public override string Name { get { return $" Discount = {FixedAmount}"; } }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FixedAmount * Math.Min(quantity, 1);
        }
    }
}
