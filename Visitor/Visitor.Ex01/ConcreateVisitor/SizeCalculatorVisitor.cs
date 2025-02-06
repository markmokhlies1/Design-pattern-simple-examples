using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Ex01.ConCreateElement;
using Visitor.Ex01.VisitorInterface;

namespace Visitor.Ex01.ConcreateVisitor
{
    public class SizeCalculatorVisitor : IVisitor
    {
        public int TotalSize { get; private set; } = 0;

        public void VisitFile(File1 file)
        {
            TotalSize += file.Size;
        }

        public void VisitFolder(Folder1 folder)
        {
            // Folders themselves do not contribute to size in this example
            Console.WriteLine($"Visiting folder: {folder.Name}");
        }
    }
}
