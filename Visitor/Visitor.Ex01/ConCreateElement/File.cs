using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Ex01.ElementInterface;
using Visitor.Ex01.VisitorInterface;

namespace Visitor.Ex01.ConCreateElement
{
    public class File1 : IFileSystemElement
    {
        public string Name { get; }
        public int Size { get; }

        public File1(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitFile(this);
        }
    }
}
