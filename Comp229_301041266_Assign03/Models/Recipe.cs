using Comp229_301041266_Assign03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Comp229_301041266_Assign03.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }

        [Required(ErrorMessage ="Please enter the recipe name.")]
        public string RecipeName { get; set; }

        [Required(ErrorMessage = "Please enter the recipe category.")]
        public string RecipeCategory { get; set; }

        [Required]
        [Range (1, int.MaxValue, ErrorMessage = "Number of portions is required.")]
        public string RecipeNumberPortions { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Enter total cook time in minutes.")]
        public string RecipeCookTime { get; set; }

        [Required(ErrorMessage = "Please enter the recipe ingredients.")]
        public string RecipeIngredient { get; set; }
        public string RecipeIngredientQty { get; set; }
        public string RecipeIngredientUnit { get; set; }

        [Required(ErrorMessage = "Please enter the recipe details.")]
        public string RecipeNarrative { get; set; }
        

    }

}
