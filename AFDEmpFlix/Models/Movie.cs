using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFDEmpFlix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Prepei na dwseis title!!!")]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Prepei na dwseis duration!!!")]
        public int Duration { get; set; }
        [Display(Name = "Trailer URL")]
        [Required(ErrorMessage = "Prepei na dwseis trailer url!!!")]
        public string TrailerUrl { get; set; }
        [Display(Name = "Thumbnail URL")]
        [Required(ErrorMessage = "Prepei na dwseis thumbnail url!!!")]
        public string ThumbnailUrl { get; set; }
    }

    public enum Genre
    {
        Action = 0,
        Horror = 1,
        [Display(Name = "Science Fiction")]
        ScienceFiction = 2,
        Comedy = 3,
        Drama = 4
    }
}