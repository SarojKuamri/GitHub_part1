using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBookStore.Models
{
    public class MovieModel
    {
        [Key]
        [Required(ErrorMessage = "Movie ID can't be empty")]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Movie Name can't be empty")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Movie Language can't be empty")]
        public string MovieLanguage { get; set; }
        [Required(ErrorMessage = "Movie Price can't be empty")]
        public string MoviePrice { get; set; }
        [Required(ErrorMessage = "Movie Description can't be empty")]
        public string MovieDescription { get; set; }
        [Required(ErrorMessage = "Movie Type can't be empty")]
        public string MovieType { get; set; }
        [Required(ErrorMessage = "Movie Location can't be empty")]
        public string MovieLocation { get; set; }
      
    }
}
