using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class CarIEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car? x, Car? y)
            => x?.Model?.Equals(y?.Model) ?? false;
        public int GetHashCode([DisallowNull] Car obj)
            => obj?.Model?.GetHashCode()??throw new ArgumentException("Object is null");
    }
}
