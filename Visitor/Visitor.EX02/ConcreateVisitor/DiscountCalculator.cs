using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.EX02.ConcreatElment;
using Visitor.EX02.VisitorInterface;

namespace Visitor.EX02.ConcreateVisitor
{
    public class DiscountCalculator : ITaxVisitor
    {
        public decimal TotalDiscount { get; private set; } = 0;

        public void Visit(Food food)
        {
            Console.WriteLine($"Calculating discount for food: {food.Name}");
            TotalDiscount += food.Price * 0.02m; // 2% discount for food
        }

        public void Visit(Electronics electronics)
        {
            Console.WriteLine($"Calculating discount for electronics: {electronics.Name}");
            TotalDiscount += electronics.Price * 0.1m; // 10% discount for electronics
        }

        public void Visit(Clothing clothing)
        {
            Console.WriteLine($"Calculating discount for clothing: {clothing.Name}");
            TotalDiscount += clothing.Price * 0.05m; // 5% discount for clothing
        }
    }
}
