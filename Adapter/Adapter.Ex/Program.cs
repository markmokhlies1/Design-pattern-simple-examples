namespace Adapter.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adaptee
            var legacyService = new LegacyFahrenheitService();

            // Adapter
            var adapter = new TemperatureAdapter(legacyService);

            // Client
            var client = new WeatherClient(adapter);
            client.DisplayTemperature();
        }
    }
}
