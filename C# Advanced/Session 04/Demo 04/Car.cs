using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class Car :IEquatable<Car>
    {
        public Car(int code, string? model, decimal speed)
        {
            Code = code;
            Model = model;
            Speed = speed;
        }

        public int Code { get; set; }
        public string? Model { get; set; }
        public decimal Speed { get; set; }

        public bool Equals(Car? other)
            => Code == other?.Code && Model == other?.Model;

        public override int GetHashCode()
            => HashCode.Combine(Code, Model);

        public override string ToString()
            => $"{Code} :: {Model} :: {Speed}";
    }
}
