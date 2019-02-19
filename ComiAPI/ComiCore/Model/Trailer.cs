using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Trailer : BaseEntity
    {
        public string Name { get; set; }
        public int MoviesId { get; set; }
        public string Path { get; set; }
        public Movies Movies { get; set; }
    }
}
