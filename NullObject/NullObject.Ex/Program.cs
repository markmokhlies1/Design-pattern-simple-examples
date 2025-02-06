namespace NullObject.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Real payment with Credit Card
            Console.WriteLine("With Credit Card Payment Processor:");
            IPaymentProcessor creditCardProcessor = new CreditCardPaymentProcessor();
            var creditCardOrder = new Order(creditCardProcessor);
            creditCardOrder.Checkout(50.0m);

            // Real payment with PayPal
            Console.WriteLine("With PayPal Payment Processor:");
            IPaymentProcessor paypalProcessor = new PayPalPaymentProcessor();
            var paypalOrder = new Order(paypalProcessor);
            paypalOrder.Checkout(75.0m);

            // No payment required
            Console.WriteLine("With Null Payment Processor:");
            IPaymentProcessor nullProcessor = new NullPaymentProcessor();
            var freeOrder = new Order(nullProcessor);
            freeOrder.Checkout(0.0m);
        }
    }
}
