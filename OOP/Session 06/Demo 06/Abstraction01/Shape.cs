using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_06.Abstraction01
{
    abstract class Shape
    {
        // Abstract Class : Is a Container For Common Code For Other Classes
        // Common Code => [Fully Implemented Members , Abstracted Members ]

        protected Shape(decimal Dim01, decimal Dim02)
        {
            this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        // Abstract Method 
        public abstract decimal calcArea();
        // Abstract Property [ ReadOnly Property ]
        public abstract decimal Premiter { get; }
    }

    // * Class : Class  => Inhertance 
    // * Class : Abstract Class  => Inhertance,Implementation 
    // * Class : Interface  => Implementation 
    // * Struct : Interface  => Implementation 

    // Concrete Class : Fully Implemented Class
    
    abstract class RefBase:Shape
    {
        protected RefBase(decimal Dim01, decimal Dim02) : base(Dim01, Dim02) { }
        public override decimal calcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Rectangle : RefBase
    {
        //public override int Premiter 
        //{
        //    get
        //    {
        //        return Dim01 * 4;
        //    }
        //} // Invalid علشان ده abstract مينفعش ازود ولا انقص من العقد  ده لو في Interface كان ينفع ازود عادي 

        public Rectangle(decimal Dim01, decimal Dim02) : base(Dim01, Dim02) { }
        public override decimal Premiter
        {
            get
            {
                return Dim01 * Dim02 *2;
            }
        }
    }

    class Square : RefBase
    {
        public Square(decimal side) : base(side, side) { }
       
        public override decimal Premiter
        {
            get
            {
                return Dim01 * 4;
            }
        }
    }


    class Circle : Shape
    {
        public Circle(decimal Radius) : base(Radius, Radius) { }
       
        public override decimal Premiter { get { return 2 * Dim01 * (decimal)Math.PI; } }

        public override decimal calcArea()
        {
            return 3.14m * Dim01 * Dim02;
        }
    }

}
