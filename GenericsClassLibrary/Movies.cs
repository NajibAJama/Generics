using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassLibrary
{
    public class Movies
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public Genre Genre { get; set; }

        public Movies(string NameOfMovie, int Year, Genre MovieGenre)
        {
            Title = NameOfMovie;
            ReleaseYear = Year;
            Genre = MovieGenre;
        }

        public string GetMovieDetails()
        {
            return $"Title: {Title}  Year: {ReleaseYear}  Genre: {Genre.Name}";
        }

    }
}
