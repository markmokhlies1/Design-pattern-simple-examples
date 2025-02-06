using Visitor.EX02.ConcreatElment;
using Visitor.EX02.ConcreateVisitor;
using Visitor.EX02.ProductInterface;

namespace Visitor.EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of products
            List<IProduct> products = new()
        {
            new Food("Bread", 1.5m),
            new Electronics("Smartphone", 700m),
            new Clothing("Jeans", 50m)
        };

            // Calculate discounts
            var discountCalculator = new DiscountCalculator();
            foreach (var product in products)
            {
                product.Accept(discountCalculator);
            }
            Console.WriteLine($"Total Discount: {discountCalculator.TotalDiscount:C}");
        }
    }
}
