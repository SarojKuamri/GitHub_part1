using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMyShow.Models
{
    public class LanguageModel
    {
        [Key]
        public int LangId { get; set; }
        public string Language { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public MovieModel MovieModel { get; set; }
    }
}
