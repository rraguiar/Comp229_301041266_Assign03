using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public ViewResult RecipeAdd()
        {
            //ViewBag.Title = "Add your Recipe";
            return View();
        }

        [HttpPost]
        [Authorize]
        public ViewResult RecipeAdd(Recipe newRecipe)
        {
            if (ModelState.IsValid)
            {
                recipeRepository.saveRecipe(newRecipe);
                TempData["message"] = $"{newRecipe.RecipeName} has been saved";
                return View("List", recipeRepository.Recipes);
            } else
            {
                return View(newRecipe);
            }
        }

        [HttpGet]
        [Authorize]
        public ViewResult RecipeEdit(int id)
        {
            //ViewBag.Title = "Edit your Recipe";

            return View(recipeRepository.Recipes.Where(item => item.RecipeID == id).FirstOrDefault());
        }

        [Authorize]
        public ViewResult DeleteRecipe (int id)
        {
            Recipe recipeToDelete = recipeRepository.Recipes.Where(item => item.RecipeID == id).FirstOrDefault();
            TempData["message"] = $"Recipe \"{recipeToDelete.RecipeName}\" has been deleted";
            recipeRepository.deleteRecipe(id);
            reviewRecipeRepository.deleteReviewRecipe(id);
            return View("List", recipeRepository.Recipes);
        }
        
        [HttpGet]
        [Authorize]
        public ViewResult ReviewAdd (int id)
        {
            ReviewRecipe reviewRecipe = new ReviewRecipe();
            reviewRecipe.RecipeNumber = id;
            return View(reviewRecipe);
        }

        [HttpPost]
        [Authorize]
        public ViewResult ReviewAdd(ReviewRecipe reviewRecipe)
        {
            if (ModelState.IsValid)
            {
                reviewRecipeRepository.saveReviewRecipe(reviewRecipe);
                TempData["message"] = $"Your review has been saved";
                List<ReviewRecipe> reviews = new List<ReviewRecipe>();
                reviews.AddRange(reviewRecipeRepository.Reviews.Where
                    (item => item.RecipeNumber == reviewRecipe.RecipeNumber));
                ViewBag.listReviews = reviews;
                return View("ViewReviews", reviews);
            }
            else
            {
                return View(reviewRecipe);
            }
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