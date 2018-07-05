using System;
using System.Collections.Generic;

namespace EntityFrameworkFirstDemo.Data
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
        public MoviesGenre GenreNavigation { get; set; }
    }
}
