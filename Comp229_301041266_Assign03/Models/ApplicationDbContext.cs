using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Comp229_301041266_Assign03.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes {get; set;}
        public DbSet<ReviewRecipe> Reviews { get; set; }
        public DbSet<Favourite> FavRecipe { get; set; }
    }
}
