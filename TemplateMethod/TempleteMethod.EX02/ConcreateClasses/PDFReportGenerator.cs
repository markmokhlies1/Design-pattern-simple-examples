using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleteMethod.EX02.AsbstactAlgorithm;

namespace TempleteMethod.EX02.ConcreateClasses
{
    public class PDFReportGenerator : ReportGenerator
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data from a database for PDF report.");
        }

        protected override void AnalyzeData()
        {
            Console.WriteLine("Analyzing data using advanced algorithms for PDF report.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting the report in PDF format.");
        }
    }
}
