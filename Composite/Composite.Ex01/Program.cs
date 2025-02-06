namespace Composite.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create leaf nodes (individual shapes)
            var circle1 = new Circle();
            var circle2 = new Circle();
            var rectangle1 = new Rectangle();

            // Create a composite group and add shapes
            var group1 = new Group();
            group1.Add(circle1);
            group1.Add(rectangle1);

            // Create another composite group and add shapes
            var group2 = new Group();
            group2.Add(group1); // Add group1 to group2
            group2.Add(circle2);

            // Draw all graphics
            Console.WriteLine("Drawing individual shapes:");
            circle1.Draw();
            rectangle1.Draw();

            Console.WriteLine("\nDrawing Group 1:");
            group1.Draw();

            Console.WriteLine("\nDrawing Group 2:");
            group2.Draw();
        }
    }
}
