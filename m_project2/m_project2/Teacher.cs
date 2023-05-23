using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    public class Teacher:Allowed_Human
    {
        public bool Simultaneousteaching;
        public List<string> tpractice = new List<string>();
        public void Chooselesson(Teacher[] tch, int t)
        {
            Console.Write("How many lessons do you want to teach?");
            int numl = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numl; i++)
            {
                Lesson ls = new Lesson();
                Console.WriteLine("Choose lesson:\n1.phytology\n2.magic\n3.sport\n4.chemistry\n5.math\n6.physic");
                string cl = Console.ReadLine();
                string lesson1;
                ls.name_teacher = tch[t].lastname;
                if (cl[0] == '1')
                {
                    lesson1 = "phytology";
                    ls.Name = lesson1;
                }
                if (cl[0] == '2')
                {
                    lesson1 = "magic";
                    ls.Name = lesson1;
                }
                if (cl[0] == '3')
                {
                    lesson1 = "sport";
                    ls.Name = lesson1;
                }
                if (cl[0] == '4')
                {
                    lesson1 = "chemistry";
                    ls.Name = lesson1;
                }
                if (cl[0] == '5')
                {
                    lesson1 = "math";
                    ls.Name = lesson1;
                }
                if (cl[0] == '6')
                {
                    lesson1 = "physic";
                    ls.Name = lesson1;
                }
                Console.WriteLine("day:sunday(a) - monday(b) - tuesday(c) - wednesday(d) - thursday(e) - friday(f) - saturday(g)");
                string day = Console.ReadLine();
                if (day[0] == 'a')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "sunday", true);
                }
                if (day[0] == 'b')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "monday", true);
                }
                if (day[0] == 'c')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "tuesday", true);
                }
                if (day[0] == 'd')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "wednesday", true);
                }
                if (day[0] == 'e')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "thursday", true);
                }
                if (day[0] == 'f')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "friday", true);
                }
                if (day[0] == 'g')
                {
                    ls.day = (Lesson.Day)Enum.Parse(typeof(Lesson.Day), "saturday", true);
                }
                Console.WriteLine("time:1.(8-10) 2.(10-12) 3.(14-16) 4.(16-18)");
                string time1 = Console.ReadLine();
                if (time1[0] == '1')
                {
                    ls.Time = "8:00";
                }
                if (time1[0] == '2')
                {
                    ls.Time = "10:00";
                }
                if (time1[0] == '3')
                {
                    ls.Time = "14:00";
                }
                if (time1[0] == '4')
                {
                    ls.Time = "16:00";
                }
                tch[t].Lessons.Add(ls);
            }
            if (tch[t].Simultaneousteaching == false)
            {
                for (int i = 0; i < tch[t].Lessons.Count; i++)
                {
                    for (int z = 0; z < tch[t].Lessons.Count; z++)
                    {
                        if (tch[t].Lessons[i].day == tch[t].Lessons[z].day)
                        {
                            if (tch[t].Lessons[i].Time == tch[t].Lessons[z].Time)
                            {
                                if (i != z)
                                {
                                    Console.WriteLine($"The hours of the classes {tch[t].Lessons[i].Name} and {tch[t].Lessons[z].Name} are the same. Please enter again.");
                                    Console.WriteLine($"Which class time do you change? 1.{tch[t].Lessons[i].Name} or 2.{tch[t].Lessons[z].Name}");
                                    int les = Convert.ToInt32(Console.ReadLine());
                                    int p;
                                    if (les == 1)
                                    {
                                        p = i;
                                    }
                                    else
                                    {
                                        p = z;
                                    }
                                    Console.WriteLine("time:1.(8-10) 2.(10-12) 3.(14-16) 4.(16-18)");
                                    string time2 = Console.ReadLine();
                                    if (time2[0] == '1')
                                    {
                                        tch[t].Lessons[p].Time = "8:00";
                                    }
                                    if (time2[0] == '2')
                                    {
                                        tch[t].Lessons[p].Time = "10:00";
                                    }
                                    if (time2[0] == '3')
                                    {
                                        tch[t].Lessons[p].Time = "14:00";
                                    }
                                    if (time2[0] == '4')
                                    {
                                        tch[t].Lessons[p].Time = "16:00";
                                    }
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine("done successfully!");
        }
        public void SameTime(Teacher[] tch, int t)
        {
            for (int i = 0; i < tch[t].Lessons.Count; i++)
            {
                for (int z = 0; z < tch[t].Lessons.Count; z++)
                {
                    if (tch[t].Lessons[i].day == tch[t].Lessons[z].day)
                    {
                        if (tch[t].Lessons[i].Time == tch[t].Lessons[z].Time)
                        {
                            if (i != z)
                            {
                                Console.WriteLine($"The hours of the classes {tch[t].Lessons[i].Name} and {tch[t].Lessons[z].Name} are the same. Please enter again.");
                                Console.WriteLine($"Which class time do you change? 1.{tch[t].Lessons[i].Name} or 2.{tch[t].Lessons[z].Name}");
                                int les = Convert.ToInt32(Console.ReadLine());
                                int p;
                                if (les == 1)
                                {
                                    p = i;
                                }
                                else
                                {
                                    p = z;
                                }
                                Console.Write("time:1.(8-10) 2.(10-12) 3.(14-16) 4.(16-18)");
                                string time2 = Console.ReadLine();
                                if (time2[0] == '1')
                                {
                                    tch[t].Lessons[p].Time = "8:00";
                                }
                                if (time2[0] == '2')
                                {
                                    tch[t].Lessons[p].Time = "10:00";
                                }
                                if (time2[0] == '3')
                                {
                                    tch[t].Lessons[p].Time = "14:00";
                                }
                                if (time2[0] == '4')
                                {
                                    tch[t].Lessons[p].Time = "16:00";
                                }
                            }
                        }
                    }
                }

            }
        }
        public void Tlesson(Teacher[] tch, int t)
        {
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < tch[t].Lessons.Count; i++)
            {
                Console.WriteLine($"Code:{tch[t].Lessons[i].Code} - Name of Lessons:{tch[t].Lessons[i].Name} - Day:{tch[t].Lessons[i].day} - Time:{tch[t].Lessons[i].Time} - Capacity:{tch[t].Lessons[i].Capacity}");
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
