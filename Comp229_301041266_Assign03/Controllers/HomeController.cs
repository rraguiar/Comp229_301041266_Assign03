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
        private IRecipeRepository recipeRepository;

        public HomeController(IRecipeRepository recipeRepo) {
            recipeRepository = recipeRepo;
        }

        //action method
        public ViewResult Index()
        {
            Recipe recipe = new Recipe();
            SetCategorySpotlight();
            return View(recipeRepository.Recipes);
        }

        //public ViewResult _RecipeOfTheDay() => View(recipeRepository.Recipes);

        public ViewResult ProfilePage()
        {
            return View();
        }


        /*public ViewResult RecipesList(Recipe recipes)
        {
            return View(RecipesRepository.Recipes);
        }*/

        // Category Spotlight
        // ------------------

        public void SetCategorySpotlight() {
            string day = GetDayofWeek();
            //string day = "Thursday"; ViewBag.day = day;// (for testing purposes only)
            string category = "";

            switch (day) {
                // Miscellaneous
                case "Sunday":
                    category = "Miscellaneous";
                    break;

                // Vegetables
                case "Monday":
                    category = "Vegetables";
                    break;

                // Soups or Salads
                case "Tuesday":
                    category = "Soups or Salads";
                    break;

                // Breads or Rolls
                case "Wednesday":
                    category = "Breads or Rolls";
                    break;

                // Main Dishes
                case "Thursday":
                    category = "Main Dishes";
                    break;

                // Desserts
                case "Friday":
                    category = "Desserts";
                    break;

                // Appetizers and Beverages
                case "Saturday":
                    category = "Appetizers and Beverages";
                    break;
            }
            ViewBag.category = category;
            ChooseRecipe(category);
        }

        public void ChooseRecipe(string category) {
            List<Recipe> recipeCandidates = new List<Recipe>();
            Random r = new Random();

            foreach (var recipe in recipeRepository.Recipes) {
                if (recipe.RecipeCategory == category) {
                    recipeCandidates.Add(recipe);
                }
            }

            int listSize = recipeCandidates.Count();
            int intChosenRecipe = r.Next(0, (listSize));
            string strChosenRecipe = recipeCandidates[intChosenRecipe].RecipeName;

            ViewBag.chosenRecipe = strChosenRecipe;
        }

        public string GetDayofWeek() {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            ViewBag.day = dt.DayOfWeek;

            return dt.DayOfWeek.ToString();
        }
    }
}
