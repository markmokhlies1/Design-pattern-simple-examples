using After.Component;

namespace After.Concreat_Componnent
{
    public class StrawberryIceCream : IceCream
    {
        public override string Description => "Strawberry Ice Cream";
        public override decimal CalculateCost() => 5.5m;
    }
}
