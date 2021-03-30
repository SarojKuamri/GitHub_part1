using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBookStore.Models
{
    public class TheatreModel
    {
        [Key]
        [Required(ErrorMessage ="Theatre Id Can't be Empty")]
        public int TheatreID { get; set; }
        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public string TheatreName { get; set; }
        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public string TheatreTypes { get; set; }
        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public string TheatreDesc { get; set; }
        [Required(ErrorMessage = "Theatre Id Can't be Empty")]
        public string TheatreLocation { get; set; }

    }
}
