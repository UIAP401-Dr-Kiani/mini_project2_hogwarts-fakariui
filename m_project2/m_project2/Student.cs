using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Student:Allowed_Human
    {
        private int passedunits;
        private int term;
        private int numberofDorm;
        public int PassedUnits { get; set; }
        public int NumberofDorm { get; set; }
        public int Term { get; set; }
        public void List_Letters()
        {
            for(int i=0; i < letter.Length; i++)
            {
                if (letter[i] != null)
                {
                    Console.WriteLine(letter[i]);
                }
            }
        }
    }
}
