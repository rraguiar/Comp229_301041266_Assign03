using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301041266_Assign03.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
        void saveRecipe(Recipe recipe);
        void deleteRecipe(int RecipeID);
    }
}
