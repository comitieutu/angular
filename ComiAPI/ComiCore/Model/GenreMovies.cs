using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class GenreMovies
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int MoviesId { get; set; }
        public Movies Movies { get; set; }
    }
}
