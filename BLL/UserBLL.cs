using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        public static volatile UserBLL instance = null;
        private static readonly object padlock = new object();
        private UserDAL userDAL = UserDAL.Instance();
        public UserBLL() { }
        public static UserBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                {
                    if (instance == null)
                        instance = new UserBLL();
                }
            return instance;
        }

        public bool newUser(User user)
        {
            return userDAL.newUser(user) > 0;
        }

        public bool newPassword(User user)
        {
            return userDAL.newPassword(user) > 0;
        }
        public User getIdByUser(User user)
        {
            return userDAL.getIdByUser(user);
        }

        public User Login(User user)
        {
            return userDAL.Login(user);
        }
    }
}
