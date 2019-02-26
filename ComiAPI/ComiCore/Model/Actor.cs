using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<MoviesActor> MoviesActors { get; set; }
    }
}
