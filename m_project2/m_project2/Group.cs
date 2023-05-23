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
        public List<Allowed_Human> group_Hufflepuff = new List<Allowed_Human>();
        public List<Allowed_Human> group_Gryffindor = new List<Allowed_Human>();
        public List<Allowed_Human> group_Ravenclaw = new List<Allowed_Human>();
        public List<Allowed_Human> group_Slytherin = new List<Allowed_Human>();
        public List<Allowed_Human> play = new List<Allowed_Human>();
       

    
    }
}
