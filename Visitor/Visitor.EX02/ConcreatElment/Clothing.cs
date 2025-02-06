using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.EX02.ProductInterface;
using Visitor.EX02.VisitorInterface;

namespace Visitor.EX02.ConcreatElment
{
    public class Clothing : IProduct
    {
        public string Name { get; }
        public decimal Price { get; }

        public Clothing(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void Accept(ITaxVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
