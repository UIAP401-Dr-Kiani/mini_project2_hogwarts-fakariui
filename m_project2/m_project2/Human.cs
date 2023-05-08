using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Human
    {
        public string firstname;
        public string lastname;
        public int dateofbirth;
        public string gender;
        public string father;
        public string username;
        public string password;
        public enum Racetype
        {
            Halfblood,
            Pureblood,
            Muggleblood,
        }
        public Racetype racetype;
    }
}
