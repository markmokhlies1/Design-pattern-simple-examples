using After.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Concreat_Componnent
{
    public class BasicIceCream : IceCream
    {
        public override string Description => "Ice Cream";
        public override decimal CalculateCost() => 3.5m;
    }
}
