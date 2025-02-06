using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Ex01.ConCreateElement;
using Visitor.Ex01.VisitorInterface;

namespace Visitor.Ex01.ConcreateVisitor
{
    public class NamePrinterVisitor : IVisitor
    {
        public void VisitFile(File1 file)
        {
            Console.WriteLine($"File: {file.Name}");
        }

        public void VisitFolder(Folder1 folder)
        {
            Console.WriteLine($"Folder: {folder.Name}");
        }
    }
}
