using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Dorm
    {
        private static int floor;
        private static int room;
        private static int bed;
        private string gender;
        public static int Floor { get; set; }
        public static  int Room { get; set; }
        public static int Bed { get; set; }
        public string Gender { get; set; }
        public static List<int> Women_dormitory = new List<int>();
        public static List<int> Men_dormitory = new List<int>();

        public static void Code()
        {
            for ( Floor = 1; Floor <= 6; Floor++)
            {
                int floor1 = Floor * 100;
                for ( Room = 0; Room <= 9; Room++)
                {
                    int room1 = Room * 10;
                    for ( Bed = 1; Bed <= 5; Bed++)
                    {
                        int cod = floor1 + room1 + Bed;
                        Women_dormitory.Add( cod );
                        Men_dormitory.Add(cod);
                    }
                }
            }
        }
    }
}
