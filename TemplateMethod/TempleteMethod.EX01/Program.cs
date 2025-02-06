using TempleteMethod.EX01.AbstactStepes;
using TempleteMethod.EX01.ConcreateClasses;

namespace TempleteMethod.EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cooking Pasta:");
            CookingRecipe pasta = new PastaRecipe();
            pasta.Cook();

            Console.WriteLine("\nCooking Salad:");
            CookingRecipe salad = new SaladRecipe();
            salad.Cook();
        }
    }
}
