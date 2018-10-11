using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Midterm
{
    class Movies
    {
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
        //public string Year { get; set; }

        public Movies(string movieName, string genre, string actor, string director)
        {
            this.MovieName = movieName;
            this.Genre = genre;
            this.Actor = actor;
            this.Director = director;
        }

        //SearchMovieName(string movieName){}
        
        //SearchGenre(string genre){}
        
        //SearchActor(string actor){}
        
        //SearchDirector(string director){}



    }
}
