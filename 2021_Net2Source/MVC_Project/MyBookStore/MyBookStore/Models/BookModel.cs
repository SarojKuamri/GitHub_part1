using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookStore.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string writer { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
