using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Movies : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Manufacture { get; set; }
        public string Status { get; set; }
        public int Episode { get; set; }
        public string Path { get; set; }
        public ICollection<Trailer> Trailers { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
