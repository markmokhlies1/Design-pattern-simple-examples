using After.Component;
using After.Decorator;

namespace After.ConcreateDecorator
{
    public class FruiteMix : IceCreamDecorator
    {
        public FruiteMix(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Fruite Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .75m;
    }
}
