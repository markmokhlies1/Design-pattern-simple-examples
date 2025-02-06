using Command.Ex.ConcreateCommand;
using Command.Ex.Invoker;
using Command.Ex.Reciver;

namespace Command.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Receiver
            var livingRoomLight = new Light();

            // Commands
            var lightOn = new LightOnCommand(livingRoomLight);
            var lightOff = new LightOffCommand(livingRoomLight);

            // Invoker
            var remote = new RemoteControl();

            // Execute commands
            Console.WriteLine("Turning the light ON:");
            remote.Submit(lightOn);

            Console.WriteLine("\nTurning the light OFF:");
            remote.Submit(lightOff);

            Console.WriteLine("\nUndoing the last command:");
            remote.Undo();

            Console.WriteLine("\nUndoing the previous command:");
            remote.Undo();

            Console.WriteLine("\nAttempting to undo when no commands are left:");
            remote.Undo();
        }
    }
}
