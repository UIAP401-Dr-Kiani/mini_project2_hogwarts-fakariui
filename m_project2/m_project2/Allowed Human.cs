using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Allowed_Human:Human
    {
        private int numberofroom;
        private string curriculum;
        public enum Pet
        {
            rat,
            cat,
            owl,
        }
        public Pet pet;
        public Group group;
        public bool baggage;
        public enum Role
        {
            teacher,
            student,
        }
        public Role role;
        private string[] letter;
        public int Numberofroom { get; set; }
        public string Curriculum { get; set; }
        public string[] Letter { get; set; }
    
    }
}
