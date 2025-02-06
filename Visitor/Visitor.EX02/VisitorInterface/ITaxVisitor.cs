using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.EX02.ConcreatElment;

namespace Visitor.EX02.VisitorInterface
{
    public interface ITaxVisitor
    {
        void Visit(Food food);
        void Visit(Electronics electronics);
        void Visit(Clothing clothing);
    }
}
