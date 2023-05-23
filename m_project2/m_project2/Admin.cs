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
       
        public List<Lesson> Lesson1 = new List<Lesson>();
        public List<Lesson> Lesson2 = new List<Lesson>();
        public List<Lesson> Lesson3 = new List<Lesson>();
        public List<Lesson> Lesson4 = new List<Lesson>();
        public void garden1(Phytology phy)
        {
            Console.WriteLine("How many types of plants do you have for this semester?");
            int numtype = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numtype; i++)
            {
                Plant pl = new Plant();
                Console.WriteLine("name:");
                string nameplant = Console.ReadLine();
                Console.WriteLine("number:");
                int numberplant = Convert.ToInt32(Console.ReadLine());
                pl.Name = nameplant;
                pl.Number = numberplant;
                phy.plant1.Add(pl);
            }
        }
        public void garden2(Phytology phy)
        {
            Console.WriteLine("How many types of plants do you have for this semester?");
            int numtype = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numtype; i++)
            {
                Plant pl = new Plant();
                Console.WriteLine("name:");
                string nameplant = Console.ReadLine();
                Console.WriteLine("number:");
                int numberplant = Convert.ToInt32(Console.ReadLine());
                pl.Name = nameplant;
                pl.Number = numberplant;
                phy.plant2.Add(pl);
            }
        }
        public void garden3(Phytology phy)
        {
            Console.WriteLine("How many types of plants do you have for this semester?");
            int numtype = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numtype; i++)
            {
                Plant pl = new Plant();
                Console.WriteLine("name:");
                string nameplant = Console.ReadLine();
                Console.WriteLine("number:");
                int numberplant = Convert.ToInt32(Console.ReadLine());
                pl.Name = nameplant;
                pl.Number = numberplant;
                phy.plant3.Add(pl);
            }
        }
        public void garden4(Phytology phy)
        {
            Console.WriteLine("How many types of plants do you have for this semester?");
            int numtype = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numtype; i++)
            {
                Plant pl = new Plant();
                Console.WriteLine("name:");
                string nameplant = Console.ReadLine();
                Console.WriteLine("number:");
                int numberplant = Convert.ToInt32(Console.ReadLine());
                pl.Name = nameplant;
                pl.Number = numberplant;
                phy.plant4.Add(pl);
            }
        }
    }
}
