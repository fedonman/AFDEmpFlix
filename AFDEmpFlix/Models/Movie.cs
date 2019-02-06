using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFDEmpFlix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public string TrailerUrl { get; set; }
        public string ThumbnailUrl { get; set; }
    }

    public enum Genre
    {
        Action,
        Horror,
        ScienceFiction,
        Comedy
    }
}