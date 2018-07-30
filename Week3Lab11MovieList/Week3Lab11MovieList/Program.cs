using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab11MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Quit = true;
            while (Quit == true)
            {
                var choice = Menu();
                //valid menu selection
                var movies = ListMovies();
                foreach (Movie movie in movies)
                {
                    if (movie.GetCategory() == choice)
                    {
                        Console.WriteLine($"{movie.GetTitle()}\n");
                    }
                }
                
            }
        }
        static string Menu()
        {
            Console.WriteLine(
@"THERE ARE MANY FILMS
    WHAT CATEGORY DO YOU WISH TO KNOW BETTER OF THESE FILMS?
    1. SCIFI
    2. FANTASY
    3. ACTION
    4. HORROR
    5. ROMANCE
    6. COMEDY
    7. ART HOUSE
ENTER THE TYPE FOR THE FILM OF THAT TYPE. MAKE SURE THERE ARE CAPITALS FOR ALL WORDS");
            string theOption = Console.ReadLine();
            if (IsValidMenuOption(theOption))
            {
                return theOption;
            }
            else
            {
                return Menu();
            }
        }

        private static bool IsValidMenuOption(string theOption)
        {
            if (theOption == "Scifi")
            {
                return true;
            }
            else if (theOption == "Fantasy")
            {
                return true;
            }
            else if (theOption == "Action")
            {
                return true;
            }
            else if (theOption == "Horror")
            {
                return true;
            }
            else if (theOption == "Romance")
            {
                return true;
            }
            else if (theOption == "Comedy")
            {
                return true;
            }
            else if (theOption == "Art House")
            {
                return true;
            }
            else
            {
                Console.WriteLine("THAT WAS NOT A CHOICE: MAKE SURE YOU HAVE CORRECT CASING.");
                return false;
            }
        }
        static List<Movie> ListMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Star Fight", "Scifi"));
            movies.Add(new Movie("Space Odyseus", "Scifi"));
            movies.Add(new Movie("Planet Crammit", "Scifi"));
            movies.Add(new Movie("Galaxy of Fighting", "Scifi"));//1
            movies.Add(new Movie("Tale of Kings", "Fantasy"));
            movies.Add(new Movie("King of Hot Mountain", "Fantasy"));
            movies.Add(new Movie("Fight for MacGuffin", "Fantasy"));
            movies.Add(new Movie("Island of Fighting", "Fantasy"));//2
            movies.Add(new Movie("Death Wanting", "Action"));
            movies.Add(new Movie("Kung-Fu Kill", "Action"));
            movies.Add(new Movie("Hardest Death", "Action"));
            movies.Add(new Movie("Killer Inspector", "Action"));//3
            movies.Add(new Movie("Cave of Scary", "Horror"));
            movies.Add(new Movie("Number of Day Spooky", "Horror"));
            movies.Add(new Movie("The Disappearer", "Horror"));
            movies.Add(new Movie("Hooded Killer", "Horror"));//4
            movies.Add(new Movie("Smootch City","Romance"));
            movies.Add(new Movie("City Romp","Romance"));
            movies.Add(new Movie("Crossing at Smootch Intersection","Romance"));
            movies.Add(new Movie("Sleepless in City","Romance"));//5
            movies.Add(new Movie("RoadTrip to Funland", "Comedy"));
            movies.Add(new Movie("Holiday Mishaps", "Comedy"));
            movies.Add(new Movie("College Goof-Offs", "Comedy"));
            movies.Add(new Movie("Comedy Fusion", "Comedy"));//6
            movies.Add(new Movie("Abstract Shapes and Lines", "Art House"));
            movies.Add(new Movie("Sombre Documentary", "Art House"));
            movies.Add(new Movie("Bildungsroman", "Art House"));
            movies.Add(new Movie("Foriegn Concept", "Art House"));//7

            return movies;
        }
    }
}
