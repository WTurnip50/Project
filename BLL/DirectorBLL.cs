using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DirectorBLL
    {
        private static volatile DirectorBLL instance = null;
        private static readonly object padlock = new object();
        private DirectorDAL directorDal = DirectorDAL.Instance();

        public DirectorBLL() { }

        public static DirectorBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new DirectorBLL();
            return instance;
        }

        public Directors GetAll()
        {
            return directorDal.getAll();
        }
    }
}
