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

        public Movies (string movieName, string genre, string actor, string director)
        {
            this.MovieName = movieName;
            this.Genre = genre;
            this.Actor=actor;
            this.Director = director;
        }
    }
}
