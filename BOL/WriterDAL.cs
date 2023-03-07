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
    public class WriterDAL
    {
        private static volatile WriterDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        public static WriterDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                {
                    if (instance == null)
                        instance = new WriterDAL();
                }
            return instance;
        }

        public int newWriter(Writer writer)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@name", writer.name);
                string query = "Writers_newWriter";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }

        public Writers getAll()
        {
            try
            {
                string query = "Writer_getALL";
                DataTable result = dataAccess.Query(query);
                Writers writer = new Writers();

                foreach (DataRow item in result.Rows)
                {
                    writer.Add(new Writer()
                    {
                        idWriter = (int)item["idWriter"],
                        name = (string)item["name"],
                        activo = (bool)item["activo"]
                    });
                }
                return writer;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error :" + ex.Message);
            }
        }

        //public Writer GetByID(Writer writer)
        //{
        //    try
        //    {
        //        SqlParameter[] parameters = new SqlParameter[1];
        //        parameters[0] = new SqlParameter("@idWriter", writer.idWriter);
        //    }
        //}

    }
}
