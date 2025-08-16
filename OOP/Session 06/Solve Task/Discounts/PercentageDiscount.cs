using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Discounts
{
    class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }
        public PercentageDiscount(int Percentage)
        {
            this.Percentage = Percentage;
        }
        public PercentageDiscount()
        {
            
        }
        public override string Name { get { return $"Discount = {Percentage}%"; } }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity-price * quantity * (Percentage / 100);
        }
        
    }
}
