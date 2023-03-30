using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WriterBLL
    {
        private static volatile WriterBLL instance = null;
        private static readonly object padlock = new object();
        private WriterDAL writerDal = WriterDAL.Instance();

        public WriterBLL() { }

        public static WriterBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new WriterBLL();
            return instance;
        }

        public bool Add(Writer writer)
        {
            if (writerDal.newWriter(writer) > 0)
                return true;
            else
                return false;
        }
        public bool Edit(Writer writer)
        {
            if (writerDal.Edit(writer) > 0)
                return true;
            else
                return false;
        }

        public Writers GetAll()
        {
            return writerDal.getAll();
        }

        public Writer GetByID(Writer writer)
        {
            return writerDal.GetByID(writer);
        }

        public bool Disable(Writer writer)
        {
            if (writerDal.Disable(writer) > 0)
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
