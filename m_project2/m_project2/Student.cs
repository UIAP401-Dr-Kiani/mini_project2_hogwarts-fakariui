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
        public DateTime dts = new DateTime();

        public List<string> spractice = new List<string>();
        public void Select_Unite2(Student[] std, Admin dombeldor, int s, int nl)
        {
            int nl1 = 0;
            while (nl1 < nl)
            {
                Console.WriteLine("enter the code of lesson:");
                int code = Convert.ToInt32(Console.ReadLine());
                if (dombeldor.Lesson2[code].NumberOfstudent != dombeldor.Lesson2[code].Capacity)
                {
                    if (nl1 != 0)
                    {
                        int countl = std[s].Lessons.Count;
                        for (int p = 0; p < countl; p++)
                        {

                            if (std[s].Lessons[p].day == dombeldor.Lesson2[code].day)
                            {
                                if (std[s].Lessons[p].Time == dombeldor.Lesson2[code].Time)
                                {

                                    Console.WriteLine($"This class interferes with the {std[s].Lessons[p].Name} class.you can not choose this lesson");
                                    break;

                                }
                                else
                                {
                                    if (p == countl - 1)
                                    {

                                        std[s].Lessons.Add(dombeldor.Lesson2[code]);
                                        dombeldor.Lesson2[code].NumberOfstudent++;
                                        nl1++;
                                        Console.WriteLine("done successfully!");
                                    }
                                }

                            }
                            else
                            {
                                if (p == countl - 1)
                                {

                                    std[s].Lessons.Add(dombeldor.Lesson2[code]);
                                    dombeldor.Lesson2[code].NumberOfstudent++;
                                    nl1++;
                                    Console.WriteLine("done successfully!");
                                }
                            }
                        }
                    }
                    if (nl1 == 0)
                    {
                        std[s].Lessons.Add(dombeldor.Lesson2[code]);
                        dombeldor.Lesson2[code].NumberOfstudent++;
                        nl1++;
                        Console.WriteLine("done successfully!");
                    }
                }
                if (dombeldor.Lesson2[code].NumberOfstudent == dombeldor.Lesson2[code].Capacity)
                {
                    Console.WriteLine("The capacity is complete. You cannot select this course");
                }

            }
        }
        public void Select_Unite3(Student[] std, Admin dombeldor, int s, int nl)
        {
            int nl1 = 0;
            while (nl1 < nl)
            {
                Console.WriteLine("enter the code of lesson:");
                int code = Convert.ToInt32(Console.ReadLine());
                if (dombeldor.Lesson3[code].NumberOfstudent != dombeldor.Lesson3[code].Capacity)
                {
                    if (nl1 != 0)
                    {
                        int countl = std[s].Lessons.Count;
                        for (int p = 0; p < countl; p++)
                        {

                            if (std[s].Lessons[p].day == dombeldor.Lesson3[code].day)
                            {
                                if (std[s].Lessons[p].Time == dombeldor.Lesson3[code].Time)
                                {

                                    Console.WriteLine($"This class interferes with the {std[s].Lessons[p].Name} class.you can not choose this lesson");
                                    break;

                                }
                                else
                                {
                                    if (p == countl - 1)
                                    {

                                        std[s].Lessons.Add(dombeldor.Lesson3[code]);
                                        dombeldor.Lesson3[code].NumberOfstudent++;
                                        nl1++;
                                        Console.WriteLine("done successfully!");
                                    }
                                }

                            }
                            else
                            {
                                if (p == countl - 1)
                                {

                                    std[s].Lessons.Add(dombeldor.Lesson3[code]);
                                    dombeldor.Lesson3[code].NumberOfstudent++;
                                    nl1++;
                                    Console.WriteLine("done successfully!");
                                }
                            }
                        }
                    }
                    if (nl1 == 0)
                    {
                        std[s].Lessons.Add(dombeldor.Lesson3[code]);
                        dombeldor.Lesson3[code].NumberOfstudent++;
                        nl1++;
                        Console.WriteLine("done successfully!");
                    }
                }
                if (dombeldor.Lesson3[code].NumberOfstudent == dombeldor.Lesson3[code].Capacity)
                {
                    Console.WriteLine("The capacity is complete. You cannot select this course");
                }

            }
        }
        public void Select_Unite4(Student[] std, Admin dombeldor, int s, int nl)
        {
            int nl1 = 0;
            while (nl1 < nl)
            {
                Console.WriteLine("enter the code of lesson:");
                int code = Convert.ToInt32(Console.ReadLine());
                if (dombeldor.Lesson4[code].NumberOfstudent != dombeldor.Lesson4[code].Capacity)
                {
                    if (nl1 != 0)
                    {
                        int countl = std[s].Lessons.Count;
                        for (int p = 0; p < countl; p++)
                        {

                            if (std[s].Lessons[p].day == dombeldor.Lesson4[code].day)
                            {
                                if (std[s].Lessons[p].Time == dombeldor.Lesson4[code].Time)
                                {

                                    Console.WriteLine($"This class interferes with the {std[s].Lessons[p].Name} class.you can not choose this lesson");
                                    break;

                                }
                                else
                                {
                                    if (p == countl - 1)
                                    {

                                        std[s].Lessons.Add(dombeldor.Lesson4[code]);
                                        dombeldor.Lesson4[code].NumberOfstudent++;
                                        nl1++;
                                        Console.WriteLine("done successfully!");
                                    }
                                }

                            }
                            else
                            {
                                if (p == countl - 1)
                                {

                                    std[s].Lessons.Add(dombeldor.Lesson4[code]);
                                    dombeldor.Lesson4[code].NumberOfstudent++;
                                    nl1++;
                                    Console.WriteLine("done successfully!");
                                }
                            }
                        }
                    }
                    if (nl1 == 0)
                    {
                        std[s].Lessons.Add(dombeldor.Lesson4[code]);
                        dombeldor.Lesson4[code].NumberOfstudent++;
                        nl1++;
                        Console.WriteLine("done successfully!");
                    }
                }
                if (dombeldor.Lesson4[code].NumberOfstudent == dombeldor.Lesson4[code].Capacity)
                {
                    Console.WriteLine("The capacity is complete. You cannot select this course");
                }
            }
        }
        public void Get_Curriculum(Student[] std, int s)
        {
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < std[s].Lessons.Count; i++)
            {
                Console.WriteLine($"Code:{std[s].Lessons[i].Code} - Name of teacher:{std[s].Lessons[i].name_teacher} - Name of Lessons:{std[s].Lessons[i].day} - Time:{std[s].Lessons[i].Time} - Capacity:{std[s].Lessons[i].Capacity}");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("done successfully");
        }
        public void Curriculum(Student[] std, int s)
        {
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < std[s].Lessons.Count; i++)
            {
                Console.WriteLine($"Code:{std[s].Lessons[i].Code} - Name of teacher:{std[s].Lessons[i].name_teacher} - Name of Lessons:{std[s].Lessons[i].day} - Time:{std[s].Lessons[i].Time} - Capacity:{std[s].Lessons[i].Capacity}");
            }
            Console.WriteLine("---------------------------------------");
        }
        public string Return_Letter(Student[] std, int s)
        {
            return ($"Hello!I am {std[s].lastname}. I want to return my city.");
        }
    }
}
