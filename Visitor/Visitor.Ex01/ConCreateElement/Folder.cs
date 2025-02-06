using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Ex01.ElementInterface;
using Visitor.Ex01.VisitorInterface;

namespace Visitor.Ex01.ConCreateElement
{
    public class Folder1 : IFileSystemElement
    {
        public string Name { get; }
        public List<IFileSystemElement> Elements { get; } = new();

        public Folder1(string name)
        {
            Name = name;
        }

        public void AddElement(IFileSystemElement element)
        {
            Elements.Add(element);
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFolder(this);
            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
