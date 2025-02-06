using Mediator.EX02.UseOfMediatorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.EX02
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new();

        public void AddUser(User user) => _users.Add(user);

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                // Do not notify the sender
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
