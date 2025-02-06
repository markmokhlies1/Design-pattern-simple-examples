using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleteMethod.EX01.AbstactStepes;

namespace TempleteMethod.EX01.ConcreateClasses
{
    public class PastaRecipe : CookingRecipe
    {
        protected override void CookDish()
        {
            Console.WriteLine("Cooking pasta and adding sauce.");
        }

        protected override void PrepareIngredients()
        {
            Console.WriteLine("Chopping garlic, boiling water, and preparing pasta.");
        }
    }
}
