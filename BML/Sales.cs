using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Sales
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idVenta { get; set; }
        public int idUser { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUser", idUser);
            parametros.Add("@fecha", fecha);
            parametros.Add("@total", total);
            return dataAccess.Execute("Sales_Add", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            parametros.Add("@idUser", idUser);
            parametros.Add("@fecha", fecha);
            parametros.Add("@total", total);
            return dataAccess.Execute("Sale_Edit", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            return dataAccess.Execute("Sale_Disable", parametros);
        }
        public Sales GetByID()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            return dataAccess.QuerySingle<Sales>("Sale_getByID", parametros);
        }
        public IEnumerable<Sales> GetAll()
        {
            return dataAccess.Query<Sales>("Sales_GetAll");
        }
    }
}
