using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MovieBLL
    {
        private static volatile MovieBLL instance = null;
        private static readonly object padlock = new object();
        private MovieDAL movieDal = MovieDAL.Instance();

        public MovieBLL() { }

        public static MovieBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new MovieBLL();
            return instance;
        }

        public bool Add(Movie movie)
        {
            if (movieDal.newMovie(movie) > 0)
                return true;
            else
                return false;
        }
        public bool Edit(Movie movie)
        {
            if (movieDal.editMovieData(movie) > 0)
                return true;
            else
                return false;
        }

        public bool Disable(Movie movie)
        {
            if (movieDal.disableMovie(movie) > 0)
                return true;
            else
                return false;
        }

        public Movies GetAll()
        {
            return movieDal.getAll();
        }

        public Movie GetByID(Movie movie)
        {
            return movieDal.GetByID(movie);
        }
    }
}
