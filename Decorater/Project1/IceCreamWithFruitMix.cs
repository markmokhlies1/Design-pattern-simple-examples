namespace Project1
{
    public class IceCreamWithFruitMix : IceCream
    {
        public override string Description => $"{base.Description} + Fruit Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .60m;
    }
}
