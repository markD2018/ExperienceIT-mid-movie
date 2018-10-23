using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Midterm
{   
    // This program allows users to browse list of movies based on the Genre, Actor, Director and MovieName
    public class Movies
    {
        // Declare Variables
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
        //public string Year { get; set; }
        
            // Declare the Constructor and pass arguments

        public Movies(string movieName, string genre, string actor, string director)
        {
            MovieName = movieName;
            Genre = genre;
            Actor = actor;
            Director = director;
        }

        // Declare a Override method that returns MovieName
        public override string ToString()
        {
            return MovieName + " - " + Genre + " - " + Actor + " - " + Director;
        }

        public Movies() {  }
       
        // Initializing the List of Movies based on the Title
        public List<Movies> SearchByTitle(List<Movies> movies)
        {
            List<Movies> searchMovies = new List<Movies>();
            string searchForTitle = "";
            Console.WriteLine("what is the title?");
            searchForTitle = Console.ReadLine().ToUpper();

            foreach (var m in movies)
            {
                if (m.MovieName.Contains(searchForTitle))
                    searchMovies.Add(m);
            }
            Console.WriteLine();
            return searchMovies; 
    }
      
        // Initializing the List of Movies based on the Genre
        public List<Movies> SearchByGenre(List<Movies> movies)
        {
            List<Movies> searchMovies = new List<Movies>();
            string searchForGenre = "";

            Console.WriteLine("what is the genre?");
            searchForGenre = Console.ReadLine().ToUpper();
            foreach (var m in movies)
            {
                if (m.Genre.Contains(searchForGenre))
                    searchMovies.Add(m);
            }
            Console.WriteLine();
            return searchMovies;
        }

        // // Initializing the List of Movies based on the Actor
        public List<Movies> SearchByActor(List<Movies> movies)
        {
            List<Movies> searchMovies = new List<Movies>();
            string searchForActor = "";

            Console.WriteLine("Who is the main actor?");
            searchForActor = Console.ReadLine().ToUpper();
            foreach (var m in movies)
            {
                if (m.Actor.Contains(searchForActor))
                    searchMovies.Add(m);
            }
            Console.WriteLine();
            return searchMovies;
        }
       
        // Initializing the List of Movies based on the Director
        public List<Movies> SearchByDirector(List<Movies> movies)
        {
            List<Movies> searchMovies = new List<Movies>();
            string searchForDirector = "";

            Console.WriteLine("Who directed the movie?");
            searchForDirector = Console.ReadLine().ToUpper();
            foreach (var m in movies)
            {
                if (m.Director.Contains(searchForDirector))
                    searchMovies.Add(m);
            }
            Console.WriteLine();
            return searchMovies;
        }
    }
}
