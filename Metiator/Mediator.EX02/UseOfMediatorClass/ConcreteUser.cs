namespace Mediator.EX02.UseOfMediatorClass
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IChatMediator mediator, string name) : base(mediator, name) { }

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            Mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }

}
