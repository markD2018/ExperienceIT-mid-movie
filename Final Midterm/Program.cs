using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing and Declaring  the list of Movies Initial List for Testing
            /*
            List<Movies> movies = new List<Movies>();
            movies.Add(new Movies("Titanic", "Romance", "Leo DiCaprio", "James Cameron"));
            movies.Add(new Movies("Smallfoot", "Comedy", "Yetie", "IDK"));
            movies.Add(new Movies("Avatar", "Action", "Blank", "James Cameron"));
            movies.Add(new Movies("Avengers", "Action", "Robert Downery Jr", "Josh Whedon"));
            movies.Add(new Movies("Antman", "Action", "Paul Rudd", "Josh Whedan"));
            */

            //Populating movie from file
            List<Movies> movies = new List<Movies>();
            // path based on local file
            //string path = @"C:\Users\mlmda\source\repos\ExperienceIT-mid-movie\Final Midterm\nameFile.txt";

            //  path based on Git Location
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\nameFile.txt");
            string line;
            string[] tempMovie = new string[4];

            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine();
            while (line != null)
            {
                tempMovie = line.Split(',');
                movies.Add(new Movies(tempMovie[0], tempMovie[1], tempMovie[2], tempMovie[3]));
                line = sr.ReadLine();
            }
            sr.Close();

            // Creating an object 
            Movies movies2 = new Movies();

            Console.WriteLine("Welcome to Team 3 Movie Library"); 
            string searchBy = "";
            string addmovie;
            string[] addMovie = new string[4];

            List<Movies> searchMovies = new List<Movies>();

            Boolean run = true;

            while(run)
            {
                Console.WriteLine("\nWould you like to: \n[1] Display movie list \n[2] search movies \n[3] Add movie \n[4] Remove Movie \nExit");
                string directive = Console.ReadLine().ToLower();

                // Implementing the Switch Case Statement

                switch (directive)
                {
                    case "1":
                        Console.WriteLine("\nTitle \t Genre \t Lead Actor \t Director");
                        foreach (var m in movies) Console.WriteLine(m); //"{0}  {1}  {2}  {3}", m.MovieName, m.Genre, m.Actor, m.Director);
                        break;
                    case "2":
                        Console.WriteLine("How would you like to search? Title, Genre, Actor, Director, go back");
                        searchBy = Console.ReadLine().ToLower();

                        switch (searchBy)
                        {
                            case "title":
                                var titles= movies2.SearchByTitle(movies);
                                Console.WriteLine();
                                foreach (var m in titles)
                                {
                                    Console.WriteLine(m);
                                }

                                break;

                            case "genre":
                                var genres = movies2.SearchByGenre(movies);
                                Console.WriteLine();
                                foreach(var n in genres)
                                {
                                    Console.WriteLine(n);
                                }
                                break;
                            case "actor":
                                var actors = movies2.SearchByActor(movies);
                                Console.WriteLine();
                                foreach (var a in actors)
                                {
                                    Console.WriteLine(a);
                                }
                                break;
                            case "director":
                                var director = movies2.SearchByDirector(movies);
                                Console.WriteLine();
                                foreach (var d in director)
                                {
                                    Console.WriteLine(d);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Write out: Title, Genre, Lead Actor, Director");
                        Console.WriteLine("Example: 'The Princess Bride, Adventure, Cary Elwes, Rob Reiner' ");
                        addmovie = Console.ReadLine();
                        addMovie = addmovie.Split(',');
                        movies.Add(new Movies(addMovie[0], addMovie[1], addMovie[2], addMovie[3]));
                        break;
                    case "4":
                        Console.WriteLine("Which Movie do you want to remove?");
                        var i = 0;
                        foreach (var m in movies) { Console.WriteLine("[{0}] {1}", i, m.MovieName); i++; }
                        i = Convert.ToInt32(Console.ReadLine());
                        movies.RemoveAt(i);
                        break;
                    case "exit":
                        run = false;
                        break;
                    
                }
                
                if (directive == "exit")
                    run = false;
            }
            StreamWriter sw = new StreamWriter(path);
            foreach (var m in movies)
            {
                sw.WriteLine("{0},{1},{2},{3}", m.MovieName, m.Genre, m.Actor, m.Director);
            }
            //Close the file
            sw.Close();

        }
    }
}
