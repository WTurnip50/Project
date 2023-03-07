using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
