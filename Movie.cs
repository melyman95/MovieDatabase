using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        [Key]
        public string Title { get; set; }

        public int releaseYear { get; set; }

        public string Rating { get; set; }

        public string Genre { get; set; }

        public int Runtime { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return Title.ToString() + ", " + releaseYear.ToString() + ", " + Rating.ToString() + ", " + Genre.ToString();
        }
    }
}
