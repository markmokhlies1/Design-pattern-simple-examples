namespace Proxcy.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("Photo1.jpg");
            IImage image2 = new ProxyImage("Photo2.jpg");

            // Image is not loaded yet
            Console.WriteLine("Images are not loaded yet.");

            // Load and display images on demand
            image1.Display();
            image2.Display();
        }
    }
}
