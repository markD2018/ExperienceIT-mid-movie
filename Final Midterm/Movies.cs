using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Midterm
{
    class Movies
    {
        public String MovieName { get; set; }
        public String Genre { get; set; }
        public String Actor { get; set; }
        public String Director { get; set; }

        public Movies (string MovieName, string Genre, string Actor, string Director)
        {
            this.MovieName = MovieName;
            this.Genre = Genre;
            this.Actor=Actor;
            this.Director = Director;
        }
    }
}
