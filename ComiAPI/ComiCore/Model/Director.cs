using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Director: BaseEntity
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<MoviesDirector> MoviesDirectors { get; set; }
    }
}
