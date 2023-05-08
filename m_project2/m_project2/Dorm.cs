using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Dorm
    {
        private int floor;
        private int room;
        private int bed;
        private string gender;
        public int Floor { get; set; }
        public int Room { get; set; }
        public int Bed { get; set; }
        public string Gender { get; set; }
        public Dorm(int _floor, int _room, int _bed)
        {
            floor = _floor;
            room = _room;
            bed = _bed;
        }
        public static void Code()
        {
            for (int floor = 1; floor <= 4; floor++)
            {
                int floor1 = floor * 100;
                for (int room = 1; room <= 5; room++)
                {
                    int room1 = room * 10;
                    for (int bed = 1; bed <= 3; bed++)
                    {
                        int cod = floor1 + room1 + bed;
                        Console.WriteLine(cod);
                    }
                }
            }
        }
    }
}
