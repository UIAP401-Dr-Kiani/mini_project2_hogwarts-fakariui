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
        public void ticket(Student[] std , int i)
        {
            Random rd = new Random();
            int day = rd.Next(1, 30);
            int month = rd.Next(5, 7);
            int houer1 = rd.Next(8, 22);
            int cabin = rd.Next(1, 10);
            int chair = rd.Next(1, 4);
            DateTime dt = new DateTime(2023, month, day, houer1, 0, 0);
            std[i].letters.Add($"Cabin number:{cabin} - Seat number:{chair} - time to move:{dt.ToString("yyyy'/'MM'/'dd HH:mm")}");
            std[i].dts = dt;
        }
        public void return_ticket(int ys , Student[] std)
        {
            Console.WriteLine("enter the Lastname of sudent:");
            string names = Console.ReadLine();
            for (int w = 0; w < ys; w++)
            {
                if (std[w].lastname == names)
                {
                    Random rd = new Random();
                    int day = rd.Next(1, 30);
                    int month = rd.Next(9, 10);
                    int houer1 = rd.Next(8, 22);
                    int cabin = rd.Next(1, 10);
                    int chair = rd.Next(1, 4);
                    DateTime dt = new DateTime(2023, month, day, houer1, 0, 0);
                    std[w].letters.Add($"Cabin number:{cabin} - Seat number:{chair} - time to move:{dt.ToString("yyyy'/'MM'/'dd HH:mm")}");
                }
            }
        }
        public void Completing_curriculum(int yt , Teacher[]tch , Admin dombeldor)
        {
            Console.WriteLine("comolet the information");
            for (int i = 0; i < yt; i++)
            {
                for (int k = 0; k < tch[i].Lessons.Count; k++)
                {
                    Console.WriteLine($"Teacher:{tch[i].lastname} - Lesson:{tch[i].Lessons[k].Name} - Day:{tch[i].Lessons[k].day} - Time:{tch[i].Lessons[k].Time}");
                    Console.WriteLine("Specify the semester:1 | 2 | 3 | 4");
                    tch[i].Lessons[k].NumberofTerm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Determine the capacity:");
                    tch[i].Lessons[k].Capacity = Convert.ToInt32(Console.ReadLine());
                    tch[i].Lessons[k].NumberOfstudent = 0;
                    Console.WriteLine("done successfully!");
                    if (tch[i].Lessons[k].NumberofTerm == 1)
                    {
                        dombeldor.Lesson1.Add(tch[i].Lessons[k]);
                    }
                    if (tch[i].Lessons[k].NumberofTerm == 2)
                    {
                        dombeldor.Lesson2.Add(tch[i].Lessons[k]);
                    }
                    if (tch[i].Lessons[k].NumberofTerm == 3)
                    {
                        dombeldor.Lesson3.Add(tch[i].Lessons[k]);
                    }
                    if (tch[i].Lessons[k].NumberofTerm == 4)
                    {
                        dombeldor.Lesson4.Add(tch[i].Lessons[k]);
                    }

                }

            }
        }
        public void select_unit1(Admin dombeldor, Student[] std, int ys )
        {
            int nl = 0;
            Console.WriteLine("Choose lessons for first semester students");
            while (1 == 1)
            {
                Console.WriteLine("How many lessons do you want to have?");
                nl = Convert.ToInt32(Console.ReadLine());
                if (nl > 5)
                {
                    Console.WriteLine("you can not choose more than 5 Lessons");
                }
                if (nl < 2)
                {
                    Console.WriteLine("you can not choose less than 2 Lessons");
                }
                if (nl <= 5 && nl >= 2)
                {
                    break;
                }
            }
            for (int i = 0; i < dombeldor.Lesson1.Count; i++)
            {
                Console.WriteLine($"{i} - Name of teacher:{dombeldor.Lesson1[i].name_teacher} - Name of Lessons:{dombeldor.Lesson1[i].Name} - Day:{dombeldor.Lesson1[i].day} - Time:{dombeldor.Lesson1[i].Time} - Capacity:{dombeldor.Lesson1[i].Capacity}");
                dombeldor.Lesson1[i].Code = 10 + i;
            }

            for (int i = 0; i < ys; i++)
            {
                if (std[i].Term == 1)
                {
                    Console.WriteLine($"name of student:{std[i].lastname}");
                    int nl1 = 0;
                    while (nl1 < nl)
                    {
                        Console.WriteLine("enter the code of lesson:");
                        int code = Convert.ToInt32(Console.ReadLine());
                        if (dombeldor.Lesson1[code].NumberOfstudent != dombeldor.Lesson1[code].Capacity)
                        {
                            if (nl1 != 0)
                            {
                                int countl = std[i].Lessons.Count;
                                for (int p = 0; p < countl; p++)
                                {

                                    if (std[i].Lessons[p].day == dombeldor.Lesson1[code].day)
                                    {
                                        if (std[i].Lessons[p].Time == dombeldor.Lesson1[code].Time)
                                        {

                                            Console.WriteLine($"This class interferes with the {std[i].Lessons[p].Name} class.you can not choose this lesson");
                                            break;

                                        }
                                        else
                                        {
                                            if (p == countl - 1)
                                            {

                                                std[i].Lessons.Add(dombeldor.Lesson1[code]);
                                                dombeldor.Lesson1[code].NumberOfstudent++;
                                                nl1++;
                                                Console.WriteLine("done successfully!");
                                            }
                                        }

                                    }
                                    else
                                    {
                                        if (p == countl - 1)
                                        {

                                            std[i].Lessons.Add(dombeldor.Lesson1[code]);
                                            dombeldor.Lesson1[code].NumberOfstudent++;
                                            nl1++;
                                            Console.WriteLine("done successfully!");
                                        }
                                    }
                                }
                            }
                            if (nl1 == 0)
                            {
                                std[i].Lessons.Add(dombeldor.Lesson1[code]);
                                dombeldor.Lesson1[code].NumberOfstudent++;
                                nl1++;
                                Console.WriteLine("done successfully!");
                            }
                        }
                        if (dombeldor.Lesson1[code].NumberOfstudent == dombeldor.Lesson1[code].Capacity)
                        {
                            Console.WriteLine("The capacity is complete. You cannot select this course");
                        }

                    }

                }
            }
        }
    }
}
