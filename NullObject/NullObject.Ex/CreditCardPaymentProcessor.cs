namespace NullObject.Ex
{
    // Real Payment Processor (Credit Card)
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}.");
        }
    }

}
