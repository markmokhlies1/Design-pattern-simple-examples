namespace Adapter.Ex
{
    // Adaptee: The existing system providing temperature in Fahrenheit
    public class LegacyFahrenheitService
    {
        public double GetTemperatureInFahrenheit()
        {
            return 98.6; // Example value
        }
    }

}
