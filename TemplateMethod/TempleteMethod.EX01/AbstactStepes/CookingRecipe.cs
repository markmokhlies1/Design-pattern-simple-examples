using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleteMethod.EX01.AbstactStepes
{
    public abstract class CookingRecipe
    {
        // Template method - defines the skeleton of the algorithm
        public void Cook()
        {
            GatherIngredients();
            PrepareIngredients();
            CookDish();
            Serve();
        }

        // Common step
        private void GatherIngredients()
        {
            Console.WriteLine("Gathering ingredients.");
        }

        // Abstract steps to be implemented by subclasses
        protected abstract void PrepareIngredients();
        protected abstract void CookDish();

        // Common step
        private void Serve()
        {
            Console.WriteLine("Serving the dish.");
        }
    }
}
