using ChainOFResponsabilty.EX;
// Technical Support Handler
public class TechnicalSupportHandler : IHandler
{
    private IHandler? _nextHandler;

    public void SetNext(IHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void HandleRequest(string issue)
    {
        if (issue.Contains("technical"))
        {
            Console.WriteLine("Technical Support: Handled the issue.");
        }
        else if (_nextHandler != null)
        {
            Console.WriteLine("Technical Support: Passing to the next handler...");
            _nextHandler.HandleRequest(issue);
        }
        else
        {
            Console.WriteLine("Technical Support: Unable to handle the issue.");
        }
    }
}

