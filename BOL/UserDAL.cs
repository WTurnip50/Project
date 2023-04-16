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
    public class UserDAL
    {
        private static volatile UserDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        public static UserDAL Instance()
        {
            if(instance == null)
                lock(padlock)
                {
                    if(instance == null)
                        instance = new UserDAL();
                }
            return instance;
        }

        public int newUser(User user)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@username", user.username);
                parameters[1] = new SqlParameter("@password", user.password);
                parameters[2] = new SqlParameter("@su", user.SU);
                string query = "Users_newUser";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }
        public int newPassword(User user)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@idUser", user.idUser);
                parameters[1] = new SqlParameter("@username", user.username);
                parameters[2] = new SqlParameter("@password", user.password);
                string query = "Users_NewPassword";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }
        public User getIdByUser(User user)
        {
            try
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@username", user.username);
                string query = "Users_getIdByUser";
                DataTable result = dataAccess.Query(query, parameter);
                if (result.Rows.Count > 0)
                {
                    user = new User()
                    {
                        idUser = (int)result.Rows[0]["idUser"],
                        username = "user",
                        password = "Pass",
                        activo = true,
                        SU = false
                    };
                }
                return user;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error : " + ex.Message);
            }
        }
        public User checkAvailable(User user)
        {
            try
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@nombre", user.username);
                string query = "FindUser";
                DataTable result = dataAccess.Query(query, parameter);
                if (result.Rows.Count > 0)
                {
                    user = new User()
                    {
                        idUser = (int)result.Rows[0]["idUser"],
                        username = (string)result.Rows[0]["username"],
                        activo = (bool)result.Rows[0]["activo"],
                    };
                    return user;
                }
                return null;
                
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error : " + ex.Message);
            }
        }
        public User Login(User user)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@username", user.username);
                parameters[1] = new SqlParameter("@pasword", user.password);
                string query = "Users_Login";
                DataTable result = dataAccess.Query(query, parameters);

                if (result.Rows.Count > 0)
                {
                    User userObj = new User()
                    {
                        idUser = (int)result.Rows[0]["idUser"],
                        username = (string)result.Rows[0]["username"],
                        password = (string)result.Rows[0]["password"],
                        activo = (bool)result.Rows[0]["activo"],
                        SU = (bool)result.Rows[0]["SU"]

                    };
                    return userObj;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error : " + ex.Message);
            }

        }   
    }
}
