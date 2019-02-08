using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateReleased { get; set; }
        public int Rating { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}