namespace State.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trafficLight = new TrafficLight("Red");

            // Simulate state transitions
            trafficLight.Request(); // Red -> Green
            trafficLight.Request(); // Green -> Yellow
            trafficLight.Request(); // Yellow -> Red
        }
    }
}
