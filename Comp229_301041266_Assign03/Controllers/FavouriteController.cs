using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Comp229_301041266_Assign03.Models;
using Microsoft.AspNetCore.Authorization;

namespace Comp229_301041266_Assign03.Controllers
{
    public class FavouriteController : Controller
    {

        private IFavouriteRecipeRespository favRepository;
        private UserManager<IdentityUser> userManager;

        public FavouriteController(IFavouriteRecipeRespository repo, UserManager<IdentityUser> userMgr)
        {
            favRepository = repo;
            userManager = userMgr;
        }
        public ViewResult AddedFavourites()
        {
            string name = userManager.GetUserId(HttpContext.User);
            List<Favourite> favs = new List<Favourite>();
            favs.AddRange(favRepository.FavRecipe.Where(item => item.user == name));
            return View(favs);
        }
            //=> View(favRepository.FavRecipe);

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
            string name = userManager.GetUserId(HttpContext.User);
            fav.user = name;
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