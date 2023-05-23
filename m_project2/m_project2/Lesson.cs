using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Lesson
    {
        private string time;
        private int numberofstudent;
        private int capacity;
        private int numberofterm;
        private string name;
        public string Time { get; set; }
        public int NumberOfstudent { get; set; }
        public int Capacity { get; set; }
        public int NumberofTerm { get; set; }
        public string Name { get; set; }
        public enum Day
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
        }
        public Day day;
        public DateTime dt = new DateTime();
        public string name_teacher;
        public int Code;
        public List<int> scores = new List<int>();
        public List<Student> students = new List<Student>();
    }
}
