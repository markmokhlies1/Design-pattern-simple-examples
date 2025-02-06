namespace NullObject.Ex
{
    // Real Payment Processor (PayPal)
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}.");
        }
    }

}
