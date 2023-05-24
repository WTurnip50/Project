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
    public class Writer
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idWriter { get; set; }
        public string name { get; set; }
        public bool activo { get; set; }


        public Writer() { }
        
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@name", name);
            return dataAccess.Execute("Writer_Add",parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idWriter", idWriter);
            parametros.Add("@name", name);
            return dataAccess.Execute("Writer_Edit", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idWriter", idWriter);
            return dataAccess.Execute("Writer_Drop",parametros);
        }
        public Writer GetByID()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idWriter", idWriter);
            return dataAccess.QuerySingle<Writer>("Writer_getByID", parametros);
        }
        public IEnumerable<Writer>GetAll()
        {
            return dataAccess.Query<Writer>("Writer_getALL");
        }

    }
}
