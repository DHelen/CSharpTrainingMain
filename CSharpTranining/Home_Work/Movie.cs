using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining.Home_Work
{
    public class Movie
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string[] Countries { get; set; }

    public  Movie()
        {
        }

        public Movie(string name, int releaseYear, string[] countries)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Countries = countries;
        }

        public Movie(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
        }
    }
}
