using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTranining.Home_Work
{
    public class _2HomeWork
    {
        

        public static void RunForEachLoop()
        {
            string[] movieNames = { "Mad Max", "The Rising Hawk", "Crocodile Dundee", "Winter on Fire", "The King" };

            Console.WriteLine("Movies contain 'The' article");
            foreach (var movieName in movieNames)
            {
                if (movieName.Contains("The"))
                {
                    Console.WriteLine(movieName);
                }
            }
        }

        public static void RunGetMoviesFromAustralia()
        {
            //Initial condition: Movies list
            Movie [] movies = {
                new Movie("Mad Max", 1979, new []{"Australia"}),
                new Movie("Crocodile Dundee", 1986, new []{"USA", "Australia"}),
                new Movie("The Rising Hawk", 1999, new []{"USA", "Ukraine"}),
                new Movie("Room", 2015, new []{"Canada", "Ireland", "United Kingdom","USA"}),
                new Movie("Winter on Fire", 2015, new []{"Ukraine","United Kingdom","Australia"," USA"}),
                new Movie("Nayakan", 1987, new []{"India"}),
                new Movie("Munich", 2005, new []{"USA", "Canada"}),
                new Movie("The King", 2019, new []{"USA", "United Kingdom", "Australia "}),
            };



            //Print movies from Australia (Template: Movie name - Release year - Country1, Country2, Country...n) 
            Console.WriteLine("Movies from Australia are:");
            for (int a = 0; a < movies.Length; a++)
            {
                for (int i = 0; i < movies[a].Countries.Length; i++)
                    if (movies[a].Countries[i].Contains("Australia"))
                    { 
                    Console.WriteLine(movies[a].Name + " - " + movies[a].ReleaseYear + " - " + movies[a].Countries[i]);
                    }
                    
                    
                

            }


        }
    }
}
