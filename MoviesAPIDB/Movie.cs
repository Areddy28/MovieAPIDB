using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPIDB
{
    
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Actor { get; set; }
        public string director { get; set; }
        public int Runtime { get; set; }
        public string Genre { get; set; }

    }
}
