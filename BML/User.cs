using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class User
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idUser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }
        public bool SU { get; set; }

        public User() {}

        public User Login()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@username",username);
            parametros.Add("@pasword", password);
            return dataAccess.QuerySingleOrDefault<User>("Users_Login",parametros);
        }
        public User GetByUser()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombre", username);
            return dataAccess.QuerySingle<User>("FindUser", parametros);
        }
        public int newPass()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUser", idUser);
            parametros.Add("@username", username);
            parametros.Add("@password", password);
            return dataAccess.Execute("Users_NewPassword",parametros);
        }
        public int newUser()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@username", username);
            parametros.Add("@password", password);
            parametros.Add("@su", SU);
            return dataAccess.Execute("Users_NewUser", parametros);
        }
    }
}
