using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiator.EX01
{
    public class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine($"{DateTime.Now}       {user.Name}    {message}");
        }
    }
}
