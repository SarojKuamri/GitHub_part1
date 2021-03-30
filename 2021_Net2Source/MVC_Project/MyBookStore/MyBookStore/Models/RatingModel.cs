using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookStore.Models
{
    public class RatingModel
    {

        [Key]
        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public int RatingID { get; set; }

        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public string Rating { get; set; }


        [ForeignKey("MovieID")]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public MovieModel moviemodeles { get; set; }
       
    }
}
