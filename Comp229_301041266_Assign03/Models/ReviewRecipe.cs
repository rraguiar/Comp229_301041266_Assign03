using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Comp229_301041266_Assign03.Models
{
    public class ReviewRecipe
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the review.")]
        public string ReviewContent { get; set; }
        public int RecipeNumber { get; set; }
        
    }
}
