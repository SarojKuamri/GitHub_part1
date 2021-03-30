using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class TheatreModel
    {

        [Key]
        public int TheatreId { get; set; }
        [Required(ErrorMessage = "Please enter  Threatre Name")]
        public string ThreatreName { get; set; }
        [Required(ErrorMessage = "Please enter  Threatre Location")]
        public string ThreatreLoccation { get; set; }
    }
}
