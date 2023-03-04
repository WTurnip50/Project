using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        #region Singleton 
        private static volatile DataAccess instance = null;
        private static readonly object padlock = new object();
        private string conString = "Data Source = DESKTOP-HO3IVR2; Initial Catalog = PP2023; Integrated Security = true";
        
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

        #region Query/Execute

        //Consulta de tablas sin parametros
        public DataTable Query(String Query)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(Query, con) { CommandType = CommandType.StoredProcedure })
            {
                con.Open();
                DataTable resultado = new DataTable();
                resultado.Load(cmd.ExecuteReader());
                return resultado;
            }
        }

        public DataTable Query(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(query, con) { CommandType = CommandType.StoredProcedure })
            {
                con.Open();
                DataTable resultado = new DataTable();
                cmd.Parameters.AddRange(parameters);
                resultado.Load(cmd.ExecuteReader());
                return resultado;
            }
        }

        public int Execute(string query, SqlParameter[] parameters)
        {
            using (var con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(query, con) { CommandType = CommandType.StoredProcedure })
            {
                con.Open();
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}
