using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int MoviesId { get; set; }
        public Movies Movies { get; set; }
    }
}
