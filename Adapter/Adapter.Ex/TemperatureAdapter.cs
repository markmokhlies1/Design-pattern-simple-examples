namespace Adapter.Ex
{
    // Adapter: Converts Fahrenheit to Celsius
    public class TemperatureAdapter : ITemperatureService
    {
        private readonly LegacyFahrenheitService _fahrenheitService;

        public TemperatureAdapter(LegacyFahrenheitService fahrenheitService)
        {
            _fahrenheitService = fahrenheitService;
        }

        public double GetTemperatureInCelsius()
        {
            double fahrenheit = _fahrenheitService.GetTemperatureInFahrenheit();
            return (fahrenheit - 32) * 5 / 9;
        }
    }

}
