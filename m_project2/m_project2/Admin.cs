using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Admin:Allowed_Human
    {
        public List<Dorm> drom;
        public Admin()
        {
            password = "Admin";
            username = "Admin";
        }

        public string entry()
        {
            return ("Hello!you cane enter Hogwarts school.");
        }
    }
}
