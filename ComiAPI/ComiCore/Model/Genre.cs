using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<GenreMovies> GenreMovies { get; set; }
    }
}
