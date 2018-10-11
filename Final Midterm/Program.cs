using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movies> movies = new List<Movies>();
            movies.Add(new Movies("Titanic", "Romance", "Leo DiCaprio", "James"));
            movies.Add(new Movies("Smallfoot", "Comedy", "Yetie", "IDK"));
            movies.Add(new Movies("Avatar", "Action", "Blank", "James Cameron"));
            movies.Add(new Movies("Avengers", "Action", "Robert Downery Jr", "Josh Whedon"));
            movies.Add(new Movies("Antman", "Antman", "Paul Rudd", "Josh Whedan"));

            Console.WriteLine("Welcome to Team 3 Movie Library"); 
            string searchBy = "";
            string searchFor = "";
            string addmovie;
            string[] addMovie = new string[4];

            Boolean run = true;

            while(run)
            {
                Console.WriteLine("\nWould you like to: \n[1] Display movie list \n[2] search movies \n[3] Add movie \n[4] Remove Movie \nExit");
                string directive = Console.ReadLine().ToLower();

                switch (directive)
                {
                    case "1":
                        Console.WriteLine("\nTitle \t Genre \t Lead Actor \t Director");
                        foreach (var m in movies) Console.WriteLine("{0}, {1}, {2}, {3}", m.MovieName, m.Genre, m.Actor, m.Director);
                        break;
                    case "2":
                        Console.WriteLine("How would you like to search? Title, Genre, Actor, Director, go back");
                        searchBy = Console.ReadLine().ToLower();

                        switch (searchBy)
                        {
                            case "title":
                                Console.WriteLine("what is the title?");
                                searchFor = Console.ReadLine();
                                //movies.SearchMovieName(searchFor);
                                break;
                            case "genre": Console.WriteLine("What is the genre?");
                                searchFor = Console.ReadLine();
                                //movies.SearchGenre(searchFor);
                                break;
                            case "actor":
                                Console.WriteLine("Who is the lead actor?");
                                searchFor = Console.ReadLine();
                                //movies.SearchActor(searchFor);
                                break;
                            case "director":
                                Console.WriteLine("Who is the Director?");
                                searchFor = Console.ReadLine();
                                //movies.SearchDirector(searchFor);
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

        }
    }
}
