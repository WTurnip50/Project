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

        public bool Add(Director director)
        {
            if (directorDal.newDirector(director) > 0)
                return true;
            else
                return false;
        }

        public Director getByID(Director director)
        {
            return directorDal.getByID(director);
        }

        public bool Edit(Director director)
        {
            if (directorDal.editDirector(director) > 0)
                return true;
            else
                return false;
        }

        public bool Disable(Director director)
        {
            if(directorDal.Disable(director) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
