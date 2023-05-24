using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Director
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDirector { get; set; }
        public string name { get; set; }
        public bool activo { get; set; }

        public Director() { }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@name", name);
            return dataAccess.Execute("Directors_Add", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDirector", idDirector);
            parametros.Add("@name", name);
            return dataAccess.Execute("Directors_Edit", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDirector", idDirector);
            return dataAccess.Execute("Directors_Disable", parametros);
        }
        public Director GetByID()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDirector", idDirector);
            return dataAccess.QuerySingle<Director>("Directors_getByID", parametros);
        }
        public IEnumerable<Director> GetAll()
        {
            return dataAccess.Query<Director>("Directors_getAll");
        }
    }
}
