using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comp229_301041266_Assign03.Models;

namespace Comp229_301041266_Assign03.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository recipeRepository;
        private IReviewRecipeRepository reviewRecipeRepository;

        public RecipeController (IRecipeRepository recipeRepo, IReviewRecipeRepository reviewRecipeRepo)
        {
            recipeRepository = recipeRepo;
            reviewRecipeRepository = reviewRecipeRepo;
        }

        public ViewResult List() => View(recipeRepository.Recipes);

        public ViewResult RecipeDetails(int RecipeID)
        {
            return View(recipeRepository.Recipes.Where(item => item.RecipeID == RecipeID).FirstOrDefault());
        }

        public ViewResult RecipeAdd()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RecipeAdd(Recipe newRecipe)
        {
            recipeRepository.saveRecipe(newRecipe);
            return View("AddedRecipe", newRecipe);
        }

        [HttpGet]
        public ViewResult RecipeEdit(int id)
        {
            return View(recipeRepository.Recipes.Where(item => item.RecipeID == id).FirstOrDefault());
        }

        public ViewResult DeleteRecipe (int id)
        {
            recipeRepository.deleteRecipe(id);
            reviewRecipeRepository.deleteReviewRecipe(id);
            return View();
        }
        
        [HttpGet]
        public ViewResult ReviewAdd (int id)
        {
            ViewBag.RecipeNumber = id;
            return View();
        }

        [HttpPost]
        public ViewResult ReviewAdd(ReviewRecipe reviewRecipe)
        {          
            reviewRecipeRepository.saveReviewRecipe(reviewRecipe);
            return View("AddedReview");
        }

        public ViewResult ViewReviews (int id)
        {
            List<ReviewRecipe> reviews = new List<ReviewRecipe>();
            reviews.AddRange(reviewRecipeRepository.Reviews.Where(item => item.RecipeNumber == id));
            ViewBag.listReviews = reviews;
            return View(reviews);
        }
    }
}