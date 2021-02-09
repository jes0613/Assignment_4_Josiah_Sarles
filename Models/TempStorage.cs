using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3_Josiah_Sarles.Models
{
    public static class TempStorage
    {
        private static List<AddMovie> movies = new List<AddMovie>();

        public static IEnumerable<AddMovie> Movies => movies;

        public static void AddMovie(AddMovie movie)
        {
            movies.Add(movie);
        }
    }
}
