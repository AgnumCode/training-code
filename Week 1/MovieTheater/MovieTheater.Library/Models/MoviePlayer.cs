using MovieTheater.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    public class MoviePlayer : IMoviePlayer
    {
        public IMovie Movie { get; set; }

        public delegate void ShowHandler(string title);

        // we'll call this event when the movie plays
        // any callers can add functions to run whenever that happens
        // by subscribing to the event
        public event ShowHandler Show;

        // instead of delegates everywhere, can use Func / Action
        // return void -> that's an Action.
        // return anything else --> that's a Func

        // Func<string, int> --> takes a string, returns an int
        // Action<string, int> --> takes a string and an int, but returns nothing

        public event Action<string> ShowWithAction;

        // we'll call this event when the movie plays
        // any subscribers can add functions to run 
        // whenever that happens by subscribing to the event
        //public event ShowHandler Show;


        public void Play (IMovie movie)
        {
            Movie = movie;

            //unsafe to call a movie like this
            //Show(movie.Title);

            // call it with null check
            if (Show != null)
            {
                Show(Movie.Title);
            }
            
            // or you can write the above like this
            // Show?.Invoke(Movie.Title);

            //null-check-related operators ?. ??
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
