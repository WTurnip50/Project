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
    public class DirectorDAL
    {
        private static volatile DirectorDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        public static DirectorDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                {
                    if (instance == null)
                        instance = new DirectorDAL();
                }
            return instance;
        }

        public Directors getAll()
        {
            try
            {
                string query = "Directors_getAll";
                DataTable result = dataAccess.Query(query);
                Directors director = new Directors();

                foreach (DataRow item in result.Rows)
                {
                    director.Add(new Director()
                    {
                        idDirector = (int)item["idDirector"],
                        name = (string)item["name"],
                        activo = (bool)item["activo"]
                    });
                }
                return director;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error :" + ex.Message);
            }
        }

        public Director getByID(Director director)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idDirector", director.idDirector);
                string query = "Directors_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);
                if(resultado.Rows.Count > 0)
                {
                    director = new Director()
                    {
                        idDirector = (int)resultado.Rows[0]["idDirector"],
                        name = (string)resultado.Rows[0]["name"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return director;
            }
            catch (Exception e)
            {

                throw new ApplicationException("Error: " + e.Message);
            }
        }

        public int newDirector(Director director)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@name", director.name);
                string query = "Directors_Add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception e)
            {

                throw new ApplicationException("Error" + e.Message);
            }
        }

        public int editDirector(Director director)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@name", director.name);
                parameters[1] = new SqlParameter("@idDirector", director.idDirector);
                string query = "Directors_Edit";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception e)
            {

                throw new ApplicationException("Error: " + e.Message);
            }
        }

        public int Disable(Director director)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idDirector", director.idDirector);
                string query = "Directors_Disable";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error: " + e.Message);
            }

        }
    }
}
