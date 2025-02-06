using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Ex01.VisitorInterface;

namespace Visitor.Ex01.ElementInterface
{
    public interface IFileSystemElement
    {
        void Accept(IVisitor visitor);
    }
}
