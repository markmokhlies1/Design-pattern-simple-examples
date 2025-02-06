namespace Project1
{
    public class IceCreamWithChocolateChips : IceCream
    {
        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base.CalculateCost() + .45m;
    }
}
