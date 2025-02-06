using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Ex01.ConCreateElement;

namespace Visitor.Ex01.VisitorInterface
{
    public interface IVisitor
    {
        public void VisitFile(File1 file);
        public void VisitFolder(Folder1 folder);
    }
}
