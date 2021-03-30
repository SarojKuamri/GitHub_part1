using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBookStore.Models
{
    public class SeatClass
    {
        [Key]
        [Required(ErrorMessage ="Seat Id can't be empty")]
        public int SeatID { get; set; }
        [Required(ErrorMessage = "Seat No can't be empty")]
        public string Seat_No { get; set; }
        [Required(ErrorMessage = "Seat Details can't be empty")]
        public string Seat_Details { get; set; }
        [Required(ErrorMessage = "Seat Type can't be empty")]
        public string seat_type { get; set; }
    }
}
