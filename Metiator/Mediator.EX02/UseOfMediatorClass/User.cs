namespace Mediator.EX02.UseOfMediatorClass
{
    public abstract class User
    {
        protected IChatMediator Mediator;
        public string Name { get; }

        protected User(IChatMediator mediator, string name)
        {
            Mediator = mediator;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

}
