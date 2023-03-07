using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProducerBLL
    {
        public static volatile ProducerBLL instance = null;
        private static readonly object padlock = new object();
        private ProducerDAL producerDAL = ProducerDAL.Instance();

        public static ProducerBLL Instance()
        {
            if(instance == null)
                lock (padlock)
                {
                    if (instance == null)
                        instance = new ProducerBLL();
                }
            return instance;
        }

        public bool Add(Producer producer)
        {
            if (producerDAL.newProducer(producer) > 0)
                return true;
            else
                return false;
        }

        public bool Edit(Producer producer)
        {
            if (producerDAL.editProducerData(producer) > 0)
                return true;
            else
                return false;
        }

        public Producers GetAll()
        {
            return producerDAL.getAll();
        }

        public Producer GetByID(Producer producer)
        {
            return producerDAL.GetByID(producer);
        }
    }
}
