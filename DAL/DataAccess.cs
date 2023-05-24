using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DataAccess
    {
        #region Singleton 
        private static volatile DataAccess instance = null;
        private static readonly object padlock = new object();
        //private string conString = "Data Source = JORDAN; Initial Catalog = PP2023; Integrated Security = true"; Conexión Jordan
        private string conString = "Data Source = DESKTOP-5549NUM; Initial Catalog = PP2023; Integrated Security = true"; // Conexión Isra

        public string InitialCatalog = "";
        public string DataSource = "";
        public string UserID = "";
        public string Password = "";
        private byte[] Clave = Encoding.ASCII.GetBytes("ClavePersonal");
        private byte[] IV = Encoding.ASCII.GetBytes("TurnipDev7.37hAES");

        private DataAccess() { }

        public static DataAccess Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new DataAccess();
            return instance;
        }
        #endregion

        #region Querys

        //Consulta la tabla.  
        public T QuerySingle<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }
        //Consulta la tabla a partir de parametros.
        public T QuerySingle<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, parameters, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }
        //Consulta la tabla a partir de parametros, en caso de no exisistir recibe un valor nulo; funcional para login.
        public T QuerySingleOrDefault<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        //Consulta la tabla para obtener un calor especifico de una columna, este  valor no se mapeara a un objeto.
        public string QueryString(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        //Consulta la tabla para obtener un calor especifico de una columna, a partir de un parametro, este  valor no se mapeara a un objeto.
        public string QueryString(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        // todos los getall con critero a retornar valores genericos 
        public IEnumerable<T> Query<T>(string query)
        {
            using(var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public IEnumerable<T> Query<T>(string query,DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, parameters, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public int Execute(string query, DynamicParameters parameters)
        {
            using(var con = new SqlConnection(conString))
            {
                return con.Execute(query, parameters, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }
        #endregion
    }
}
