using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class TheaterModel
    {
        [Key]
        public int TheaterId { get; set; }
        [Required(ErrorMessage ="Please enter  Threator Name")]
        public string ThreaterName { get; set; }
        [Required(ErrorMessage = "Please enter  Threator Location")]
        public string ThreaterLoc { get; set; }
    }
}
