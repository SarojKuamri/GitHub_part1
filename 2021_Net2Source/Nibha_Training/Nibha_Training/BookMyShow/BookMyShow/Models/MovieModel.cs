using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class MovieModel
    {
        [Key]
        public int MovieId {get; set;}
        [Required(ErrorMessage ="Please enter Movie Name")]
        public string MovieName { get; set; }
        [Required(ErrorMessage =("Please enter Movie Type"))]
        public string MovieType { get; set; }
        public int MoviePrice { get; set; }
    }
}
