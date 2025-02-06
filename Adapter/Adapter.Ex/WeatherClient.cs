namespace Adapter.Ex
{
    // Client: Works with the Target interface
    public class WeatherClient
    {
        private readonly ITemperatureService _temperatureService;

        public WeatherClient(ITemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        public void DisplayTemperature()
        {
            Console.WriteLine($"Temperature in Celsius: {_temperatureService.GetTemperatureInCelsius():F2}°C");
        }
    }

}
