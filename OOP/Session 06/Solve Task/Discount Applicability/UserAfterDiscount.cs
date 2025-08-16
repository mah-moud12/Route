using Solve_Task.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class UserAfterDiscount : User
    {
        public SpecificUser SpecificUser { get; set; }
        public override string? Name { 
            get
            {
                return $"Type User : {SpecificUser}";
            }
        }

        public override Discount GetDiscount(SpecificUser specificUser)
        {
            if (SpecificUser == SpecificUser.RegularUser)
            {
                Discount discount = new PercentageDiscount(5);
                return discount;
            }
            else if (SpecificUser == SpecificUser.PremiumUser)
            {
                Discount discount = new FlatDiscount(100);
                return discount;
            }
            else
            {
                Discount discount = new NoDiscount();
                return discount;
            }
            
        }
        

    }
}
