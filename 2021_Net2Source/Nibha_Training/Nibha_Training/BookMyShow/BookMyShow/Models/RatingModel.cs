using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BookMyShow.Models
{
    public class RatingModel
    {
        [Key]
        public int RatingId { get; set; }
        public int MovieRatings { get; set; }
       [ForeignKey("MovieId")]
        public int MovieId { get; set; }
   
        public MovieModel MovieModel { get; set; }
    }
}
