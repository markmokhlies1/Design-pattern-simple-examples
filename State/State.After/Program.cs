using State.After.Concreate;
using State.After.Context;

namespace State.After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trafficLight = new TrafficLight(new RedLightState());

            // Simulate state transitions
            trafficLight.Request(); // Red -> Green
            trafficLight.Request(); // Green -> Yellow
            trafficLight.Request(); // Yellow -> Red
        }
    }
}
