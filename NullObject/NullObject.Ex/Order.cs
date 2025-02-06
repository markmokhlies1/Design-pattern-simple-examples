namespace NullObject.Ex
{
    // Client Code: Order Class
    public class Order
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public Order(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(decimal amount)
        {
            Console.WriteLine("Checking out...");
            _paymentProcessor.ProcessPayment(amount);
            Console.WriteLine("Order completed.\n");
        }
    }

}
