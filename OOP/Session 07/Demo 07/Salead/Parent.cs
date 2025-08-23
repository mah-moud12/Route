using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_07.Salead
{
    // Salead هو اني امنع الوراثة بس كده 
    class Parent
    {
        int salary;
        public virtual int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value+1000;
            }
        }
        public virtual void Print()
        {
            Console.WriteLine("I am Parent.");
        }

       
    }

    /*sealed  كده انا منعت ان حد يورث منه */ class Child:Parent
    {
        /*sealed كده انا منعت ان لو حد ورث من child انه يعمل override على الفانكشن دي*/
        /*sealed*/ public override void Print()
        {
            Console.WriteLine("I am child.");
        }

        public sealed override int Salary
        {
            get
            {
                return base.Salary;
            }
            set
            {
                base.Salary = value + 2000;
            }
        
        }
    }
    class GrandChild : Child
    {
        public override void Print()
        {
            Console.WriteLine("I am Grand Child.");
        }
        //public override int Salary // Invalid علشان Salead
        //{
        //    get
        //    {
        //        return base.Salary;
        //    }
        //    set
        //    {
        //        base.Salary = value + 2000;
        //    }

        //}

    }
}
