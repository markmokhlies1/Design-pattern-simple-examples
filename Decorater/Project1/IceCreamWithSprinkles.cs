namespace Project1
{
    public class IceCreamWithSprinkles : IceCream
    {
        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base.CalculateCost() + .25m;
    }
}
