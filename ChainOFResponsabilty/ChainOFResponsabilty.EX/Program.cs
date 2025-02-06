namespace ChainOFResponsabilty.EX
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Create handlers
            var customerSupport = new CustomerSupportHandler();
            var technicalSupport = new TechnicalSupportHandler();
            var manager = new ManagerHandler();
            var staff=new StaffHandler();

            // Set up the chain
            customerSupport.SetNext(technicalSupport);
            technicalSupport.SetNext(manager);
            manager.SetNext(staff);

            // Test the chain
            Console.WriteLine("Sending a basic issue...");
            customerSupport.HandleRequest("This is a basic issue.");

            Console.WriteLine("\nSending a technical issue...");
            customerSupport.HandleRequest("This is a technical issue.");

            Console.WriteLine("\nSending an escalation issue...");
            customerSupport.HandleRequest("This is an escalation issue.");

            Console.WriteLine("\nSending an unknown issue...");
            customerSupport.HandleRequest("This is an unknown issue.");

            Console.WriteLine("\nSending an big issue...");
            customerSupport.HandleRequest("This is an big issue.");


            Console.ReadKey();
        }
    }
}
