using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301041266_Assign03.Models
{
    public class EFFavouriteRespository : IFavouriteRecipeRespository
    {
        private ApplicationDbContext context;

        public EFFavouriteRespository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Favourite> FavRecipe => context.FavRecipe;

        public void addFavRecipe(Favourite fav)
        {
            Favourite newFav = new Favourite();
            newFav.RecID = fav.RecID;
            newFav.fvname = fav.fvname;
            context.Add(newFav);
            context.SaveChanges();
        }
        public void deleteFavouriteRecipe(int FID)
        {
            Favourite dbEntry = context.FavRecipe.FirstOrDefault(p => p.FavID == FID);
            if (dbEntry != null)
            {
                context.FavRecipe.Remove(dbEntry);
                context.SaveChanges();
            }
        }
    }
}
