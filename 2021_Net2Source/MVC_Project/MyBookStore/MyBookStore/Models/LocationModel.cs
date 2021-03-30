using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBookStore.Models
{
    public class LocationModel
    {
        [Key]
        [Required (ErrorMessage ="Location Id can't be empty")]
        public int LocationID { get; set; }
        [Required(ErrorMessage = "Location can't be empty")]
        public string Location { get; set; }
    }
}
