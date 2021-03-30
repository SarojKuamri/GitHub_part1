using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class RatingModel
    {
        [Key]
        public int RatingId { get; set; }
        public int MovieRatings { get; set; }
               
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public MovieModel MovieModel { get; set; }
    }
}
