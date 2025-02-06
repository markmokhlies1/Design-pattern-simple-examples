using After.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Decorator
{
    public class IceCreamDecorator : IceCream
    {
        protected IceCream _iceCream;

        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override string Description => _iceCream.Description;
        public override decimal CalculateCost() => _iceCream.CalculateCost();
    }
}
