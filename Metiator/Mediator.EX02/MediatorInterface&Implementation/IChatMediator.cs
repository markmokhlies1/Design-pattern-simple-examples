using Mediator.EX02.UseOfMediatorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.EX02
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
