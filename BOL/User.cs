using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class User
    {
        public int idUser { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public bool activo { get; set; }

        public bool SU { get; set; }

        public User() { }
    }
}
