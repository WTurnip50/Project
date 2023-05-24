using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Pelicula
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idMovie { get; set; }
        public string title { get; set; }
        public int idWriter { get; set; }
        public int idDirector { get; set; }
        public int idProducer { get; set; }

        public Pelicula() { }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@title", title);
            parametros.Add("@idWriter", idWriter);
            parametros.Add("@idDirector", idDirector);
            parametros.Add("@idProducer", idProducer);
            return dataAccess.Execute("Movies_newMovie", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMovie", idMovie);
            parametros.Add("@title", title);
            parametros.Add("@idWriter", idWriter);
            parametros.Add("@idDirector", idDirector);
            parametros.Add("@idProducer", idProducer);
            return dataAccess.Execute("Movies_EditMovie", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMovie", idMovie);
            return dataAccess.Execute("Movies_Disable", parametros);
        }
        public Pelicula GetByID()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMovie", idMovie);
            return dataAccess.QuerySingle<Pelicula>("Movie_getByID", parametros);
        }
        public IEnumerable<Pelicula> GetAll()
        {
            return dataAccess.Query<Pelicula>("Movies_getALL");
        }
        public Pelicula getByDescription()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@title",title);
            return dataAccess.QuerySingleOrDefault<Pelicula>("Movies_getByDesc", parametros);
        }
        public Pelicula getByCode()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@title", title);
            return dataAccess.QuerySingleOrDefault<Pelicula>("Movies_getByDesc", parametros);
        }
    }
}
