using Mediator.EX02.UseOfMediatorClass;

namespace Mediator.EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the mediator
            IChatMediator chatMediator = new ChatMediator();

            // Create users
            User user1 = new ConcreteUser(chatMediator, "Alice");
            User user2 = new ConcreteUser(chatMediator, "Bob");
            User user3 = new ConcreteUser(chatMediator, "Charlie");

            // Add users to the chat
            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            // Send messages
            user1.Send("Hello, everyone!");
            user2.Send("Hi, Alice!");
            user3.Send("Hey, Alice and Bob!");
        }
    }
}
