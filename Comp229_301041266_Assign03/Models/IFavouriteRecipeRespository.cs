using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301041266_Assign03.Models
{
    public interface IFavouriteRecipeRespository
    {
        IQueryable<Favourite> FavRecipe { get; }
        void addFavRecipe(Favourite fav);
        void deleteFavouriteRecipe(int FID);
    }
}
