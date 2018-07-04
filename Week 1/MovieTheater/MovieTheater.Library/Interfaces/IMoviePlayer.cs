using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Interfaces
{
    public interface IMoviePlayer
    {
        void Play(IMovie movie);
        void Stop();

        //void delegate ShowHandler();
        //event Show();
    }
}
