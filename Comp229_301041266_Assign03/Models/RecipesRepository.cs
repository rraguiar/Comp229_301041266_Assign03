using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp229_301041266_Assign03.Models;

namespace Comp229_301041266_Assign03.Models
{
    public static class RecipesRepository 
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public static IEnumerable<Recipe> Recipes
        {
            get { return recipes; }
        }


        public static void AddRecipe(Recipe newRecipe)
        {
            recipes.Add(newRecipe);
        }



    }
}
