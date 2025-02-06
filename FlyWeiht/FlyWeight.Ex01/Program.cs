namespace FlyWeight.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();

            forest.PlantTree(10, 20, "Oak", "Green", "Rough");
            forest.PlantTree(15, 25, "Pine", "Dark Green", "Smooth");
            forest.PlantTree(10, 20, "Oak", "Green", "Rough"); // Reuses the Oak TreeType

            Console.WriteLine("\nDrawing the forest:");
            forest.Draw();
        }
    }
}
