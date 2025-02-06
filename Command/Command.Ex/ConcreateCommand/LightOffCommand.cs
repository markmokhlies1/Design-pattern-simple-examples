using Command.Ex.CommandInterface;
using Command.Ex.Reciver;

namespace Command.Ex.ConcreateCommand
{
    // Concrete Command: Light Off
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }
}

