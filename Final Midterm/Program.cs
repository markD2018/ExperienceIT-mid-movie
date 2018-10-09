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
            Console.Write("Please search by movie title, genre, actor, or director");

            List<Movies> movies = new List<Movies>();

            movies.Add(new Movies("Titanic", "Romance", "Leo DiCaprio", "James"));
            movies.Add(new Movies("Smallfoot", "Comedy", "Yetie", "IDK"));
            movies.Add(new Movies("Avatar", "Action", "Blank", "James Cameron"));
            movies.Add(new Movies("Avengers", "Action", "Robert Downery Jr", "Josh Whedon"));
            movies.Add(new Movies("Antman", "Antman", "Paul Rudd", "Josh Whedan"));

            switch ()

            Console.ReadLine();
        }
    }
}
