using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
 
namespace BookMyShow.Models
{
    public class LocationModel
    {
        [Key]
        [Required(ErrorMessage ="LocationId cannot be empty")]
        public int LocqationId { get; set; }
        [Required(ErrorMessage ="Location cannot be empty")]
        public string Location { get; set; }
    }
}
