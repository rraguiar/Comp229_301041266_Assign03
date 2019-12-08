using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Comp229_301041266_Assign03.Models
{
    public class Favourite
    {
        [Key]
        public int FavID { get; set; }
        public int RecID { get; set; }
        public string fvname { get; set; }
    }
}
