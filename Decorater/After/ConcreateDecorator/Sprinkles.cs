using After.Component;
using After.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.ConcreateDecorator
{
    public class Sprinkles : IceCreamDecorator
    {
        public Sprinkles(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base.CalculateCost() + .25m;
    }
}
