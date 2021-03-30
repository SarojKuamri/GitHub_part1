using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyBookStore.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {
        }
      public DbSet<LocationModel> locationModels { get; set; }
        public DbSet<MovieModel> MovieModels { get; set; }
        public DbSet<RatingModel> RatingModels { get; set; }
      
    }
}
