using TempleteMethod.EX01.AbstactStepes;

namespace TempleteMethod.EX01.ConcreateClasses
{
    public class SaladRecipe : CookingRecipe
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Chopping vegetables and preparing dressing.");
        }

        protected override void CookDish()
        {
            Console.WriteLine("Mixing vegetables with dressing.");
        }
    }
}
