using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.EX02.VisitorInterface;

namespace Visitor.EX02.ProductInterface
{
    public interface IProduct
    {
        void Accept(ITaxVisitor visitor);
    }
}
