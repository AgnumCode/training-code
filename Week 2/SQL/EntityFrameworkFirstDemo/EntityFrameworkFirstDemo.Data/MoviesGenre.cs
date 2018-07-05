using System;
using System.Collections.Generic;

namespace EntityFrameworkFirstDemo.Data
{
    public partial class MoviesGenre
    {
        public MoviesGenre()
        {
            Movie = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}
