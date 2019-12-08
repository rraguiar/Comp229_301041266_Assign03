using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comp229_301041266_Assign03.Models; // reference to using the Models I created

namespace Comp229_301041266_Assign03.Controllers
{
    public class HomeController : Controller
    {
        //action method
        public ViewResult Index()
        {

            Recipe recipe = new Recipe();
            return View();
        }
        public ViewResult ProfilePage()
        {
            return View();
        }

        /*public ViewResult RecipeDetails(int RecipeID)
        {            
            return View(RecipesRepository.Recipes.Where( item => item.RecipeID == RecipeID).FirstOrDefault());
        }

        /*public ViewResult RecipesList(Recipe recipes)
        {
            return View(RecipesRepository.Recipes);
        }*/
    }
}
