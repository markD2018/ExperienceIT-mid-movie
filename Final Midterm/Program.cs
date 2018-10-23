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
            //Populating movie from file
            List<Movies> movies = new List<Movies>();

            //  path based on Location
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\nameFile.txt");
            string line;
            string[] tempMovie = new string[4];

            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine().ToUpper();
            while (line != null)
            {
                tempMovie = line.Split(',');
                movies.Add(new Movies(tempMovie[0], tempMovie[1], tempMovie[2], tempMovie[3]));
                line = sr.ReadLine();
                if (line != null)
                    line = line.ToUpper();
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
                Console.WriteLine("\nWould you like to: \n[1] Display Movie List \n[2] Search Movies \n[3] Add Movie \n[4] Remove Movie \nExit");
                string directive = Console.ReadLine().ToLower();

                // Implementing the Switch Case Statement
                switch (directive)
                {
                    case "1":
                        Console.WriteLine("\nTitle \t Genre \t Lead Actor \t Director");
                        foreach (var m in movies) Console.WriteLine(m); //"{0}  {1}  {2}  {3}", m.MovieName, m.Genre, m.Actor, m.Director);
                        break;
                    case "2":
                        Console.WriteLine("How would you like to search? Title, Genre, Actor, Director, go back, Exit program");
                        searchBy = Console.ReadLine().ToUpper();

                        switch (searchBy)
                        {
                            case "TITLE":
                                var titles= movies2.SearchByTitle(movies);
                                Console.WriteLine();
                                foreach (var m in titles)
                                {
                                    Console.WriteLine(m);
                                }
                                break;

                            case "GENRE":
                                var genres = movies2.SearchByGenre(movies);
                                Console.WriteLine();
                                foreach(var n in genres)
                                {
                                    Console.WriteLine(n);
                                }
                                break;
                            case "ACTOR":
                                var actors = movies2.SearchByActor(movies);
                                Console.WriteLine();
                                foreach (var a in actors)
                                {
                                    Console.WriteLine(a);
                                }
                                break;
                            case "DIRECTOR":
                                var director = movies2.SearchByDirector(movies);
                                Console.WriteLine();
                                foreach (var d in director)
                                {
                                    Console.WriteLine(d);
                                }
                                break;
                            case "EXIT":
                                    run = false;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Write out: Title, Genre, Lead Actor, Director");
                        Console.WriteLine("Example: 'The Princess Bride, Adventure, Cary Elwes, Rob Reiner' ");
                        addmovie = Console.ReadLine().ToUpper();
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
                    case "EXIT":
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
            Console.WriteLine("File Saved");
            sw.Close();

            Console.ReadKey(); 
        }
    }
}
