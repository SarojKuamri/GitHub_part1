using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class LocationModel
    {

        [Key]
        [Required(ErrorMessage = "Location Id can't be empty")]
        public int LocationID { get; set; }
        [Required(ErrorMessage = "Location can't be empty")]
        public string Location { get; set; }
    }
}
