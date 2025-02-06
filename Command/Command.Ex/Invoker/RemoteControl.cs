using Command.Ex.CommandInterface;

namespace Command.Ex.Invoker
{
    public class RemoteControl
    {
        private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void Submit(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                var command = _commandHistory.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
}

