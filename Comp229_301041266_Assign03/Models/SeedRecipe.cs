using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Comp229_301041266_Assign03.Models
{
    public static class SeedRecipe
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "Steak perfect, non sauce.",
                        RecipeCategory = "Main Dishes",
                        RecipeNumberPortions = "2",
                        RecipeCookTime = "20",
                        RecipeIngredient = "T-Bone Steak (12oz), rocky salt and grinded black pepper",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Lay the T-Bone Steak at normal temperature and put rocky salt and black pepper to taste on both sides. " +
                        "Pre-heat the Air Fryer for 5 mins at 200 degrees celsius and put the steak 6 minutes each side for medium-rare. Leave it to" +
                        " rest inside the AirFryer, off, for 1 1/2 minute before serving. The AyrFrier off will keep a good temperature for the core of " +
                        "the steak to be medium-rare but not raw neigher red boold in it."
                    },
            new Recipe
            {
                RecipeName = "Juicy Roasted Chicken",
                RecipeCategory = "Main Dishes",
                RecipeNumberPortions = "6",
                RecipeCookTime = "100",
                RecipeIngredient = "whole chicken (giblets removed), " +
                "salt and black pepper, onion powder to taste, margarine, stalk celery",
                RecipeIngredientQty = "to taste",
                RecipeIngredientUnit = "to taste",
                RecipeNarrative = "1- Preheat oven to 350 degrees F (175 degrees C). 2- Place chicken in a roasting pan, " +
                "and season generously inside and out with salt and pepper. Sprinkle inside and out with onion powder. " +
                "Place 3 tablespoons margarine in the chicken cavity. Arrange dollops of the remaining margarine around the " +
                "chicken's exterior. Cut the celery into 3 or 4 pieces, and place in the chicken cavity. 3- Bake uncovered 1 hour " +
                "and 15 minutes in the preheated oven, to a minimum internal temperature of 180 degrees F(82 degrees C). Remove " +
                "from heat, and baste with melted margarine and drippings.Cover with aluminum foil, and allow to rest about 30 " +
                "minutes before serving."
            },
            new Recipe
            {
                RecipeName = "Strawberry with Nutella",
                RecipeCategory = "Desserts",
                RecipeNumberPortions = "6",
                RecipeCookTime = "10",
                RecipeIngredient = "12 strawberries, 4 spoons of Nutella, 2 spoons of milk",
                RecipeIngredientQty = "to taste",
                RecipeIngredientUnit = "to taste",
                RecipeNarrative = "Mix the Nutella with the milk, deep the strawberries and serve. Divine..."
            }
            );

                context.Reviews.AddRange(
                    new ReviewRecipe
                    {
                        RecipeNumber = 1,
                        ReviewContent = "Great recipe!"
                    },
                    new ReviewRecipe
                    {
                        RecipeNumber = 2,
                        ReviewContent = "Like this recipe!"
                    },
                    new ReviewRecipe
                    {
                        RecipeNumber = 2,
                        ReviewContent = "Didn´t like it."
                    },
                    new ReviewRecipe
                    {
                        RecipeNumber = 2,
                        ReviewContent = "Love it!"
                    },
                    new ReviewRecipe
                    {
                        RecipeNumber = 2,
                        ReviewContent = "Made for my kids, the loved!"
                    },
                    new ReviewRecipe
                    {
                        RecipeNumber = 3,
                        ReviewContent = "Divine! Made it for friends, it was the high of the night!"
                    },
                    new ReviewRecipe
                    {
                        RecipeNumber = 3,
                        ReviewContent = "Do it twice a week, love!"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
