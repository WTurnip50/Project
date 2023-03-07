using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class MovieDAL
    {
        private static volatile MovieDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        public static MovieDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new MovieDAL();
            return instance;
        }

        public int newMovie(Movie movie)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@title", movie.title);
                parameters[1] = new SqlParameter("@idWriter", movie.idWriter);
                parameters[2] = new SqlParameter("@idDirector", movie.idDirector);
                parameters[3] = new SqlParameter("@idProducer", movie.idProducer);
                string query = "Movies_newMovie";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }
        public int editMovieData(Movie movie)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@idMovie", movie.idMovie);
                parameters[1] = new SqlParameter("@title", movie.title);
                parameters[2] = new SqlParameter("@idWriter", movie.idWriter);
                parameters[3] = new SqlParameter("@idDirector", movie.idDirector);
                parameters[4] = new SqlParameter("@idProducer", movie.idProducer);
                string query = "Movies_EditMovie";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        } 
        public int disableMovie(Movie movie)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idMovie", movie.idMovie);
                string query = "Movies_Disable";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }
        public Movies getAll()
        {
            try
            {
                string query = "Movies_GetALL";
                DataTable result = dataAccess.Query(query);
                Movies movies = new Movies();

                foreach (DataRow item in result.Rows)
                {
                    movies.Add(new Movie()
                    {
                        idMovie = (int)item["idMovie"],
                        title = (string)item["title"],
                        idWriter = (int)item["idWriter"],
                        idDirector = (int)item["idDirector"],
                        idProducer = (int)item["idProducer"],
                        available = (bool)item["available"]
                    });
                }
                return movies;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error :" + ex.Message);
            }
        }
        public Movies getInfo(Movie movie)
        {
            try
            {
                string query = "ProducerName";
                DataTable result = dataAccess.Query(query);
                Movies movies = new Movies();

                foreach (DataRow item in result.Rows)
                {
                    movies.Add(new Movie()
                    {
                        idMovie = (int)item["idMovie"],
                        title = (string)item["title"],
                        idWriter = (int)item["Writer"],
                        idDirector = (int)item["Director"],
                        idProducer = (int)item["Producer"],
                        //available = (bool)item["available"]
                    });

                }
                return movies;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error: " + ex.Message);
            }
        }

        public Movie GetByID(Movie movie)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idMovie", movie.idMovie);
                string query = "Movie_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    movie = new Movie()
                    {
                        idMovie = (int)resultado.Rows[0]["idMovie"],
                        title = (string)resultado.Rows[0]["title"],
                        idWriter = (int)resultado.Rows[0]["idWriter"],
                        idDirector = (int)resultado.Rows[0]["idDirector"],
                        idProducer = (int)resultado.Rows[0]["idProducer"],
                        available = (bool)resultado.Rows[0]["available"]
                    };
                }
                return movie;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }
    }
}
