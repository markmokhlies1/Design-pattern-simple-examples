using State.After.Context;
using State.After.Interface;

namespace State.After.Concreate
{
    public class YellowLightState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            Console.WriteLine("Yellow Light: Slow Down!");
            context.SetState(new RedLightState()); // Transition to Red
        }
    }
}
