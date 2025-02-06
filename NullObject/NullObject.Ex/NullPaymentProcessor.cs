namespace NullObject.Ex
{
    // Null Object Implementation
    public class NullPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Do nothing
            Console.WriteLine("No payment required.");
        }
    }

}
