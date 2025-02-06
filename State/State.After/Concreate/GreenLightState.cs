using State.After.Context;
using State.After.Interface;

namespace State.After.Concreate
{
    public class GreenLightState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            Console.WriteLine("Green Light: Go!");
            context.SetState(new YellowLightState()); // Transition to Yellow
        }
    }
}
