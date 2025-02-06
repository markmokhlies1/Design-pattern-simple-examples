using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsabilty.EX
{
    public class StaffHandler : IHandler
    {
        private IHandler _nextHandler;
        public void HandleRequest(string issue)
        {

            if (issue.Contains("big"))
            {
                Console.WriteLine("Staff: Handled the big issue.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("staff: Passing to the next handler...");
                _nextHandler.HandleRequest(issue);
            }
            else
            {
                Console.WriteLine("staff: Unable to handle the issue.");
            }
        }
        public void SetNext(IHandler Handler)
        {
            _nextHandler = Handler;
        }
    }
}
