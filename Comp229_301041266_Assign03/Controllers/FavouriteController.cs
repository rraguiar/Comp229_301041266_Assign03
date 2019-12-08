using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comp229_301041266_Assign03.Models;
using Microsoft.AspNetCore.Authorization;

namespace Comp229_301041266_Assign03.Controllers
{
    public class FavouriteController : Controller
    {

        private IFavouriteRecipeRespository favRepository;

        public FavouriteController(IFavouriteRecipeRespository repo)
        {
            favRepository = repo;
        }
        public ViewResult AddedFavourites()
            => View(favRepository.FavRecipe);

        [HttpGet]
        [Authorize]
        public ViewResult FavAdd(int id)
        {
            ViewBag.RecId = id;
            return View();
        }
        [HttpPost]
        public ViewResult FavAdd(Favourite fav)
        {
            favRepository.addFavRecipe(fav);
            return View("FavAdded");
        }

        [HttpGet]
        [Authorize]
        public ViewResult DeleteFavourite(int id)
        {
            
            favRepository.deleteFavouriteRecipe(id);
            return View();
        }

    }
}