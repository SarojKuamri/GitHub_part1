using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Controllers;
using Microsoft.EntityFrameworkCore;


namespace BookMyShow.Models
{
    public class MovieDBContext: DbContext
    {

        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {
        }
        public DbSet<MovieModel> MovieModels { get; set; }
        public DbSet<LocationModel> locationModels { get; set; }
        public DbSet<TheatreModel> TheatreModels { get; set; }
        public DbSet<RatingModel> RatingModels { get; set; }
        public DbSet<RegisterModel> RegisterModels { get; set; }
        //public DbSet<LoginViewModel> loginViewModels { get; set; }


    }

}
