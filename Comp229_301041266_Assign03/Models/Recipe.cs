using Comp229_301041266_Assign03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301041266_Assign03.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string RecipeCategory { get; set; }
        public string RecipeNumberPortions { get; set; }
        public string RecipeCookTime { get; set; }
        public string RecipeIngredient { get; set; }
        public string RecipeIngredientQty { get; set; }
        public string RecipeIngredientUnit { get; set; }
        public string RecipeNarrative { get; set; }
        

    }

}
