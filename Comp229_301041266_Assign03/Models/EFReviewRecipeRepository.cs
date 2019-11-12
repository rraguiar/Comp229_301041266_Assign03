using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301041266_Assign03.Models
{
    public class EFReviewRecipeRepository : IReviewRecipeRepository
    {

        private ApplicationDbContext context;

        public EFReviewRecipeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ReviewRecipe> Reviews => context.Reviews;
        public void saveReviewRecipe(ReviewRecipe reviewRecipe)
        {
            ReviewRecipe newReview = new ReviewRecipe();
            newReview.RecipeNumber = reviewRecipe.RecipeNumber;
            newReview.ReviewContent = reviewRecipe.ReviewContent;
            context.Add(newReview);
            context.SaveChanges();
        }
        public void deleteReviewRecipe(int RecipeID)
        {
            IQueryable<ReviewRecipe> returnedReviews = context.Reviews
                .Where(rv => rv.RecipeNumber == RecipeID);
            if (returnedReviews != null)
            {
                foreach (var item in returnedReviews)
                {
                    context.Reviews.Remove(item);
                }
                context.SaveChanges();
            }
        }

    }
}
