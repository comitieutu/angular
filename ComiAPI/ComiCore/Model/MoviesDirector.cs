﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class MoviesDirector
    {
        public int DierctorId { get; set; }
        public Director Director { get; set; }
        public int MoviesId { get; set; }
        public Movies Movies { get; set; }
    }
}
