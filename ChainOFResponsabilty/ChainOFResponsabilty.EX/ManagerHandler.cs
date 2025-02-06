using ChainOFResponsabilty.EX;
// Manager Handler
public class ManagerHandler : IHandler
{
    private IHandler? _nextHandler;

    public void SetNext(IHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void HandleRequest(string issue)
    {
        if (issue.Contains("escalation"))
        {
            Console.WriteLine("Manager: Handled the escalated issue.");
        }
        else if (_nextHandler != null)
        {
            Console.WriteLine("Manager: Passing to the next handler...");
            _nextHandler.HandleRequest(issue);
        }
        else
        {
            Console.WriteLine("Manager: Unable to handle the issue.");
        }
    }
}

