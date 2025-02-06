using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleteMethod.EX02.AsbstactAlgorithm
{
    public abstract class ReportGenerator
    {
        // Template method - defines the steps to generate a report
        public void GenerateReport()
        {
            FetchData();
            AnalyzeData();
            FormatReport();
            PrintReport();
        }

        // Abstract steps to be implemented by subclasses
        protected abstract void FetchData();
        protected abstract void AnalyzeData();

        // Common step with a default implementation
        protected virtual void FormatReport()
        {
            Console.WriteLine("Formatting the report in a standard layout.");
        }

        // Common step
        private void PrintReport()
        {
            Console.WriteLine("Printing the report.");
        }
    }
}
