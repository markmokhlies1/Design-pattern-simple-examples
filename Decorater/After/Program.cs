using After.Component;
using After.Concreat_Componnent;
using After.ConcreateDecorator;

namespace After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IceCream order = new StrawberryIceCream();
            order = new Sprinkles(order);
            order = new ChocolateChips(order);
            order = new FruiteMix(order);
            Console.WriteLine(order);

            Console.ReadKey();
        }
    }
}
