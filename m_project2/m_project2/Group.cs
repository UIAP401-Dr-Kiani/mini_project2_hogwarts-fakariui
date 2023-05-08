using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Group
    {
        public enum Type1
        {
            Hufflepuff,
            Gryffindor,
            Ravenclaw,
            Slytherin,
        }
        public Type1 type1;
        private int score;
        public int Score { get; set; }
        public List<Group> group;
        public List<Group> play;

    
    }
}
