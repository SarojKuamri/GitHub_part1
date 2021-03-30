using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
        public DbSet<LocationModel> locationModels { get; set; }
        public DbSet<MovieModel> MovieModels { get; set; }
        public DbSet<TheaterModel> TheaterModels { get; set; }
        public DbSet<RatingModel> RatingModels { get; set; }

    }
}
