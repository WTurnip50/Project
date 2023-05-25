using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Cart
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idCart { get; set; }
        public int idUser { get; set; }
        public int idMovie { get; set; }
        public decimal precio { get; set; }
        public Cart() { }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUser", idUser);
            parametros.Add("@idMovie", idMovie);
            parametros.Add("@precio", precio);
            return dataAccess.Execute("ShoppingCart_Add", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCart", idCart);
            parametros.Add("@idUser", idUser);
            parametros.Add("@idMovie", idMovie);
            parametros.Add("@precio", precio);
            return dataAccess.Execute("ShoppingCart_Edit", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCart", idCart);
            return dataAccess.Execute("ShoppingCart_Disable", parametros);
        }
        public int EmptyCart()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUser", this.idUser);
            return dataAccess.Execute("ShoppingCart_SaleComplete", parametros);
        }
        public IEnumerable<Cart>GetByID()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUser", idUser);
            return dataAccess.Query<Cart>("ShoppingCart_GetByID", parametros);
        }
        public IEnumerable<Cart> GetAll()
        {
            return dataAccess.Query<Cart>("ShoppingCart_getAll");
        }
    }
}
