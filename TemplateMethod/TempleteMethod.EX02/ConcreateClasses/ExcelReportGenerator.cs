using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleteMethod.EX02.AsbstactAlgorithm;

namespace TempleteMethod.EX02.ConcreateClasses
{
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data from a CSV file for Excel report.");
        }

        protected override void AnalyzeData()
        {
            Console.WriteLine("Performing basic analysis for Excel report.");
        }
    }
}
