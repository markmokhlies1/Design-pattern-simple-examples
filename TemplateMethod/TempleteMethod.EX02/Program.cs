using TempleteMethod.EX02.AsbstactAlgorithm;
using TempleteMethod.EX02.ConcreateClasses;

namespace TempleteMethod.EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating PDF Report:");
            ReportGenerator pdfReport = new PDFReportGenerator();
            pdfReport.GenerateReport();

            Console.WriteLine("\nGenerating Excel Report:");
            ReportGenerator excelReport = new ExcelReportGenerator();
            excelReport.GenerateReport();
        }
    }
}
