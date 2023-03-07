using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Movie
    {
        public int idMovie { get; set; }

        public string title { get; set; }

        public int idWriter { get; set; }

        public int idDirector { get; set; }

        public int idProducer { get; set; }

        public bool available { get; set; }
        public Movie(){}
    }
}
