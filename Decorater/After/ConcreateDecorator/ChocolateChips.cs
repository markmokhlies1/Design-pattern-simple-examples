using After.Component;
using After.Decorator;

namespace After.ConcreateDecorator
{
    public class ChocolateChips : IceCreamDecorator
    {
        public ChocolateChips(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base.CalculateCost() + .45m;
    }
}
