using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class RegisterModel
    {
        [key]

        [Required(ErrorMessage = "Register ID can't be empty")]
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName can't be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName can't be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "EmailId can't be empty")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "pwd can't be empty")]
        public string pwd { get; set; }

        [Required(ErrorMessage = "retypwd can't be empty")]
        public string retypwd { get; set; }
    }
}
