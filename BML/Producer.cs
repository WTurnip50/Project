using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Producer
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idProducer { get; set; }
        public string name { get; set; }
        public bool activo { get; set; }

        public Producer() { }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@name", name);
            return dataAccess.Execute("Producers_newProducer", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@id", idProducer);
            parametros.Add("@name", name);
            return dataAccess.Execute("Producers_EditProducer", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducer", idProducer);
            return dataAccess.Execute("Producers_Disable", parametros);
        }
        public Producer GetByID()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducer", idProducer);
            return dataAccess.QuerySingle<Producer>("Producers_getByID", parametros);
        }
        public IEnumerable<Producer> GetAll()
        {
            return dataAccess.Query<Producer>("Producers_getAll");
        }
    }
}
