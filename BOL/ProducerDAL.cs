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
    public class ProducerDAL
    {
        private static volatile ProducerDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        //private ProducerDAL producerDal = ProducerDAL.Instance();
    

        public static ProducerDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                {
                    if (instance == null)
                        instance = new ProducerDAL();
                }
            return instance;
        }

        public Producers getAll()
        {
            try
            {
                string query = "Producers_getALL";
                DataTable result = dataAccess.Query(query);
                Producers producers = new Producers();

                foreach (DataRow item in result.Rows)
                {
                    producers.Add(new Producer()
                    {
                        idProducer = (int)item["idProducer"],
                        name = (string)item["name"],
                        activo = (bool)item["activo"]
                    });
                }
                return producers;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error :" + ex.Message);
            }
        }

        public int newProducer(Producer producer)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@name", producer.name);
                string query = "Producers_newProducer";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }

        public int editProducerData(Producer producer)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@id", producer.idProducer);
                parameters[1] = new SqlParameter("@name", producer.name);
                string query = "Producers_EditProducer";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error : " + ex.Message);
            }
        }

        public Producer GetByID(Producer producer)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idProducer", producer.idProducer);
                string query = "Producers_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    producer = new Producer()
                    {
                        idProducer = (int)resultado.Rows[0]["idProducer"],
                        name = (string)resultado.Rows[0]["name"],
                        activo = (bool)resultado.Rows[0]["activo"],
                    };
                }
                return producer;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }
    }
}
