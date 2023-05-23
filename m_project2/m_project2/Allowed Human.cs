using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Allowed_Human:Human
    {
        public List<Lesson> Lessons = new List<Lesson>();
        public enum Pet
        {
            rat,
            cat,
            owl,
        }
        public Pet pet;
        public Group group = new Group();
        public bool baggage;
        public enum Role
        {
            teacher,
            student,
        }
        public Role role;
        public List<string> letters = new List<string>();
        public void List_Letters()
        {
            for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i] != null)
                {
                    Console.WriteLine(letters[i]);
                }
            }
        }

    }
}
