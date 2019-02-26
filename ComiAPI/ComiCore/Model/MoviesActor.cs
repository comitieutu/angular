using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class MoviesActor
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int MoviesId { get; set; }
        public Movies Movies { get; set; }
    }
}
