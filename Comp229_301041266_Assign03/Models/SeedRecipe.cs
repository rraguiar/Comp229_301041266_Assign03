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
                        RecipeName = "Mystic Crystal Ball",
                        RecipeCategory = "Miscellaneous",
                        RecipeNumberPortions = "10",
                        RecipeCookTime = "120",
                        RecipeIngredient = "4 cups snow, 1 cup mystic crystal, 1 teaspoon moon sand, salt, pepper",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Pour snow, crystal, and moon sand into pot. Bake in oven at 320 degrees fahrenheit for 2 hours or until shiny bright. Season with salt and pepper to taste."
                    },
                    new Recipe
                    {
                        RecipeName = "Sweetroll",
                        RecipeCategory = "Miscellaneous",
                        RecipeNumberPortions = "1",
                        RecipeCookTime = "1",
                        RecipeIngredient = "1 sweetroll, 1 cup of tears",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Prepare 1 sweetroll. Leave it for 5 minutes. Cry to a guard because someone stole your sweetroll."
                    },
                    new Recipe
                    {
                        RecipeName = "Melba Toast with Cheese",
                        RecipeCategory = "Breads or Rolls",
                        RecipeNumberPortions = "1",
                        RecipeCookTime = "2",
                        RecipeIngredient = "4 melba toast, 4 cheese slices, sliced vegetables of your choice",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Place one cheese slice on each melba toast. Place vegetables of choice on top of each melba toast."
                    },
                    new Recipe
                    {
                        RecipeName = "Toast with Margarine",
                        RecipeCategory = "Breads or Rolls",
                        RecipeNumberPortions = "1",
                        RecipeCookTime = "2",
                        RecipeIngredient = "1 toast, margarine",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Toast a piece of toast on medium or until golden brown. " +
                                          "Spread margarine on toast to taste."
                    },
                    new Recipe
                    {
                        RecipeName = "Taco Salad",
                        RecipeCategory = "Soups or Salads",
                        RecipeNumberPortions = "1-2",
                        RecipeCookTime = "10",
                        RecipeIngredient = "1 chopped cabbage, 1 jalapeno pepper, 1 red onion, 1 sliced carrot, 1 sliced cilantro, 1 lime juice",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Mix cabbage, jalapeno pepper, red onion, carrot, cilantro, and lime juice into a bowl. Stir and enjoy."
                    },
                    new Recipe
                    {
                        RecipeName = "Vegetable Soup",
                        RecipeCategory = "Soups or Salads",
                        RecipeNumberPortions = "2",
                        RecipeCookTime = "30",
                        RecipeIngredient = "14 ounce chicken broth, 12 ounce vegetable juice, 1 cup water, 1 sliced potato, 2 sliced carrots, 2 sliced celery, 1 sliced tomato, 1 sliced green beans, 1 can corn kernels, salt, pepper, other seasoning of your choice",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Pour chicken broth, vegetable juice, water, potatoes, carrots, celery, tomoatoes, green beans, and corn into pot. " +
                        "Season with salt, pepper, other seasoning to taste. " +
                        "Simmer for 30 minutes."
                    },
                    new Recipe
                    {
                        RecipeName = "Cucumber Sandwich",
                        RecipeCategory = "Vegetables",
                        RecipeNumberPortions = "1",
                        RecipeCookTime = "5",
                        RecipeIngredient = "1 sliced cucumber, 2 toast",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Place sliced cucumbers on top of a piece of toast. " +
                                          "Place another piece of toast on top."
                    },
                    new Recipe
                    {
                        RecipeName = "Seasoned Carrots",
                        RecipeCategory = "Vegetables",
                        RecipeNumberPortions = "1-2",
                        RecipeCookTime = "5",
                        RecipeIngredient = "2 sliced carrots, seasoning of your choice",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Slice two carrots. " +
                                          "Season carrots to taste."
                    },
                    new Recipe
                    {
                        RecipeName = "Tortilla Chips & Dip",
                        RecipeCategory = "Appetizers and Beverages",
                        RecipeNumberPortions = "2-4",
                        RecipeCookTime = "2",
                        RecipeIngredient = "1 bag Tortilla chips, 3 tablespoons salsa, 1 tablespoon sour cream",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "In a bowl, pour 3 tablespoons salsa." +
                                          "In the middle, place 1 tablespoon sour cream." +
                                          "In another bowl, pour Tortilla chips." +
                                          "Stir chips and enjoy."
                    },
                    new Recipe
                    {
                        RecipeName = "Iced Water",
                        RecipeCategory = "Appetizers and Beverages",
                        RecipeNumberPortions = "1",
                        RecipeCookTime = "1",
                        RecipeIngredient = "1 cup water, 1 cup ice",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Pour 1 cup of ice into a cup." +
                                          "Pour 1 cup of water on top." +
                                          "Stir and enjoy!"
                    },
                    new Recipe
                    {
                        RecipeName = "Cookies and Iced Cream",
                        RecipeCategory = "Desserts",
                        RecipeNumberPortions = "1",
                        RecipeCookTime = "1",
                        RecipeIngredient = "2 scoops vanilla iced cream, 2 whole chocolate chip cookies, 1 teaspoon chocolate syrup",
                        RecipeIngredientQty = "to taste",
                        RecipeIngredientUnit = "to taste",
                        RecipeNarrative = "Break the cookies into small pieces. " +
                                          "Put one scoop of iced cream into a cup. " +
                                          "Pour half of small cookie pieces on top of iced cream. " +
                                          "Put another scoop of iced cream into the cup." +
                                          "Pour rest of small cookie pieces on top of iced cream." +
                                          "Top iced cream and cookies with the chocolate syrup."
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
                    },
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

                context.FavRecipe.AddRange(
                    new Favourite
                    {
                        RecID = 3,
                        fvname = "Best Dinner",
                        user = "dd2957ce-f10f-48ad-a04d-d64dfaef00ed"

                    },
                    new Favourite
                    {
                        RecID = 2,
                        fvname = "Can't stop Loving",
                        user = "d669d4e9-f496-45e0-b997-e3a941f85cef"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
