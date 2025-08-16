using Solve_Task.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    abstract class User
    {
        public abstract string? Name  { get; }
        public abstract Discount GetDiscount(SpecificUser specificUser);
    }
}
