using Visitor.Ex01.ConCreateElement;
using Visitor.Ex01.ConcreateVisitor;

namespace Visitor.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create file system structure
            var file1 = new File1("File1.txt", 100);
            var file2 = new File1("File2.txt", 200);
            var folder = new Folder1("Folder1");
            folder.AddElement(file1);
            folder.AddElement(file2);

            var rootFolder = new Folder1("Root");
            rootFolder.AddElement(folder);
            rootFolder.AddElement(new File1("File3.txt", 300));

            // Use SizeCalculatorVisitor
            var sizeCalculator = new SizeCalculatorVisitor();
            rootFolder.Accept(sizeCalculator);
            Console.WriteLine($"Total Size: {sizeCalculator.TotalSize}");

            // Use NamePrinterVisitor
            var namePrinter = new NamePrinterVisitor();
            rootFolder.Accept(namePrinter);
        }
    }
}
