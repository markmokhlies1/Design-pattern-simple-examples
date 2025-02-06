using ChainOFResponsabilty.EX;
// Customer Support Handler
public class CustomerSupportHandler : IHandler
{
    private IHandler? _nextHandler;

    public void SetNext(IHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void HandleRequest(string issue)
    {
        if (issue.Contains("basic"))
        {
            Console.WriteLine("Customer Support: Handled the issue.");
        }
        else if (_nextHandler != null)
        {
            Console.WriteLine("Customer Support: Passing to the next handler...");
            _nextHandler.HandleRequest(issue);
        }
        else
        {
            Console.WriteLine("Customer Support: Unable to handle the issue.");
        }
    }
}

