using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301041266_Assign03.Models
{
    public interface IReviewRecipeRepository
    {
        
        IQueryable<ReviewRecipe> Reviews { get; }
        void saveReviewRecipe(ReviewRecipe review);
        void deleteReviewRecipe(int ReviewID);
        
    }
}
