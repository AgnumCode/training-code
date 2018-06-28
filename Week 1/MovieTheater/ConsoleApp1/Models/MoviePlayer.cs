using MovieTheater.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    public class MoviePlayer : IMoviePlayer
    {
        public IMovie Movie { get; set;  }

        public delegate void ShowHandler(string title);

        // call this event when the movie plays
        // any callers can add functions to run whenever this happens
        // by subscribing to the event
        public event ShowHandler Show;

        // instead of delgates, everywhere, can use Func / action
        // return -> void thats an action
        // return anything else -> thats a func

        // Func<string, int> -- takes  a string, returns an int
        // Action<string, int> -- takes a string & int, returns nothing
        public event Action<string> ShowWithAction;

        public void Play(IMovie movie)
        {
            Movie = movie;
            // unsafe to call an event like this 

            //Show(movie.Title);
            if (Show != null)
            {
                Show(movie.Title);
            }

            // can also be done like this
            // Show?.Invoke(Movie.title);       // null check automatically with ?
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        
           
        
    }
}
