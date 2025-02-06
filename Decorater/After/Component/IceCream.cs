using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Component
{
    public abstract class IceCream
    {
        public abstract string Description { get; }
        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"{Description} ({CalculateCost().ToString("C")})";
        }
    }
}
