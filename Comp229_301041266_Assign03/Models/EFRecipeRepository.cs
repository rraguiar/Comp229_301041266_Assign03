using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp229_301041266_Assign03.Models;

namespace Comp229_301041266_Assign03.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public void saveRecipe(Recipe recipe)
        {
            if (recipe.RecipeID == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe dbEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeID == recipe.RecipeID);
                if (dbEntry != null)
                {
                    dbEntry.RecipeName = recipe.RecipeName;
                    dbEntry.RecipeCategory = recipe.RecipeCategory;
                    dbEntry.RecipeNumberPortions = recipe.RecipeNumberPortions;
                    dbEntry.RecipeCookTime = recipe.RecipeCookTime;
                    dbEntry.RecipeIngredient = recipe.RecipeIngredient;
                    dbEntry.RecipeIngredientQty = recipe.RecipeIngredientQty;
                    dbEntry.RecipeIngredientUnit = recipe.RecipeIngredientUnit;
                    dbEntry.RecipeNarrative = recipe.RecipeNarrative;
                }
            }
            context.SaveChanges();
        }
        public void deleteRecipe(int RecipeID)
        {
            EFReviewRecipeRepository efReviewRepository = new EFReviewRecipeRepository(context);
            efReviewRepository.deleteReviewRecipe(RecipeID);
            Recipe dbEntry = context.Recipes
.FirstOrDefault(p => p.RecipeID == RecipeID);
            if (dbEntry != null)
            {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
        }
    }
}
