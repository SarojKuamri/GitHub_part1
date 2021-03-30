using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBookStore.Models
{
    public class ShowClass
    {
        [Key]
        [Required(ErrorMessage ="Show Id Can't be Empty")]
        public int ShowID { get; set; }
        [Required(ErrorMessage = "Show Timing Can't be Empty")]
        public string Show_Timing { get; set; }
        [Required(ErrorMessage = "Show Hours Can't be Empty")]
        public string Show_hours { get; set; }
        [Required(ErrorMessage = "Show Description Can't be Empty")]
        public string Show_Desc { get; set; }
    }
}
