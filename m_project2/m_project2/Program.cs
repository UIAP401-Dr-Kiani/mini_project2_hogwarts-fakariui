﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin dombeldor = new Admin();
            Allowed_Human[] ah = new Allowed_Human[500];
            Student[] std = new Student[500];
            Teacher[] tch = new Teacher[500];
            int y = 0;
            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;
                int m = 0;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] human = ln.Split('\t').ToArray<string>();
                    /*
                    human[0] = name
                    human[1] = family
                    human[2] = dataOfBirth
                    human[3] = gender
                    human[4] = father
                    human[5] = username
                    human[6] = password
                    human[7] = race type
                    human[8] = role
                    */
                    ah[m] = new Allowed_Human();
                    ah[m].firstname = human[0];
                    ah[m].lastname = human[1];
                    ah[m].dateofbirth=human[2];
                    ah[m].gender = human[3];
                    ah[m].father = human[4];
                    ah[m].username = human[5];
                    ah[m].password = human[6];
                    string h7 = human[7].Replace(" ", "");
                    ah[m].racetype =(Human.Racetype) Enum.Parse(typeof(Human.Racetype),h7,true);
                    ah[m].role = (Allowed_Human.Role)Enum.Parse(typeof(Allowed_Human.Role),human[8],true);
                    m++;
                    y++;
                }
                file.Close();
            }

            int ys = 0;
            int j = 0;
            for (int i = 0; i < y ; i++)
            {
                if ((int)ah[i].role == 1)
                {
                    std[j] = new Student();
                    std[j].firstname = ah[i].firstname;
                    std[j].lastname = ah[i].lastname;
                    std[j].dateofbirth = ah[i].dateofbirth;
                    std[j].gender = ah[i].gender;
                    std[j].father = ah[i].father;
                    std[j].username = ah[i].username;
                    std[j].password = ah[i].password;
                    std[j].racetype = ah[i].racetype;
                    j++;
                    ys++;
                }
            }
            int r = 0;
            int yt = 0;
            for (int i = 0; i < y ; i++)
            {
                if ((int)ah[i].role == 0)
                {
                    tch[r] = new Teacher();
                    tch[r].firstname = ah[i].firstname;
                    tch[r].lastname = ah[i].lastname;
                    tch[r].dateofbirth = ah[i].dateofbirth;
                    tch[r].gender = ah[i].gender;
                    tch[r].father = ah[i].father;
                    tch[r].username = ah[i].username;
                    tch[r].password = ah[i].password;
                    tch[r].racetype = ah[i].racetype;
                    r++;
                    yt++;
                }
            }

            while (1 == 1)
            {
                Console.WriteLine("Choose one:");
                Console.WriteLine("a)dombeldor\nb)teacher\nc)student\ne)Exit");
                string c = Console.ReadLine();
                if (c[0] == 'a')
                {
                    while (1 == 1)
                    {
                        Console.Write("Enter username:");
                        string username = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter password");
                        string password = Console.ReadLine();
                        Console.WriteLine();
                        if (dombeldor.username == username && dombeldor.password == password)
                        {
                            Console.WriteLine("correct!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("incorrect,pleas enter again!");
                        }
                    }
                    while (1 == 1)
                    {
                        Console.WriteLine("1.Sending letter(a)\n2.List of letters(b)\n3.Send train tickets(c)\n4.Completing the curriculum(d)\n5.Curriculum for first semester students(f)\n5.Gardening(g)\n6.Exit(e)");
                        string cd = Console.ReadLine();
                        if (cd[0] == 'a')
                        {
                            for (int i = 0; i < std.Length; i++)
                            {
                                std[i].letter[0] = dombeldor.entry();//////////////
                            }
                            Console.WriteLine("Letters have been sent successfully");
                        }
                        if (cd[0] == 'b')
                        {
                            /*for (int i = 0; i < dombeldor.letter.Length; i++)
                            {
                                Console.WriteLine(dombeldor.letter[i]);
                                
                            }*/
                            dombeldor.List_Letters();
                        }
                        if (cd[0] == 'c')
                        {
                            //*******
                        }
                        if (cd[0] == 'd')
                        {
                            //**********

                        }
                        if (cd[0] == 'f')
                        {
                            //*****
                        }
                        if (cd[0] == 'g')
                        {
                            //////////
                        }
                        if (cd[0] == 'e')
                        {
                            break;
                        }
                    }

                }
                if (c[0] == 'b')
                {
                    int w = 0;
                    int t = 0;
                    while (1 == 1)
                    {
                        Console.Write("Enter username:");
                        string username1 = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter password");
                        string password1 = Console.ReadLine();
                        Console.WriteLine();

                        for (int i = 0; i < yt ; i++)
                        {
                            if (tch[i].username == username1 && tch[i].password == password1)
                            {
                                Console.WriteLine("correct!");
                                t = i;
                                w = 1;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("incorrect,pleas enter again!");
                                break;
                            }
                        }
                        if (w == 1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Can you teach in two classes at the same time?\n1.Yes(a)  2.No(b)");
                    string answer = Console.ReadLine();
                    if (answer[0] == 'a')
                    {
                        tch[t].Simultaneousteaching = true;
                    }
                    else
                    {
                        tch[t].Simultaneousteaching = false;
                    }
                    while (1 == 1)
                    {
                        Console.WriteLine("1.Choose lesson with time(a)\n2.Send exercise(b)\n3.List of student(c)\n4.Exit(e)");
                        string ct = Console.ReadLine();
                        if (ct[0] == 'a')
                        {

                        }
                        if (ct[0] == 'b')
                        {

                        }
                        if (ct[0] == 'c')
                        {

                        }

                        if (ct[0] == 'e')
                        {
                            break;
                        }
                    }

                }
                if (c[0] == 'c')
                {
                    int q = 0;
                    int s = 0;
                    while (1 == 1)
                    {
                        Console.Write("Enter username:");
                        string username2 = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter password");
                        string password2 = Console.ReadLine();
                        Console.WriteLine();

                        for (int i = 0; i < ys ; i++)
                        {
                            if (std[i].username == username2 && std[i].password == password2)
                            {
                                Console.WriteLine("correct!");
                                s = i;
                                q = 1;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("incorrect,pleas enter again!");
                                break;
                            }
                        }
                        if (q == 1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("What semester are you in?\n1.one\n2.two\n3.three\n4.four");
                    string answer1 = Console.ReadLine();
                    std[s].Term = Convert.ToInt32(answer1[0]);
                    if (answer1[0] != '1')
                    {
                        Console.WriteLine("What is your group?\n1.Hufflepuff(a)\n2.Gryffindor(b)\n3.Ravenclaw(c)\n4.Slytherin(d)");
                        string answer2 = Console.ReadLine();
                        if (answer2[0] == 'a')
                        {
                            std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Hufflepuff", true);
                        }
                        if (answer2[0] == 'b')
                        {
                            std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Gryffindor", true);
                        }
                        if (answer2[0] == 'c')
                        {
                            std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Ravenclaw", true);
                        }
                        if (answer2[0] == 'd')
                        {
                            std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Slytherin", true);
                        }

                    }
                    while (1 == 1)
                    {
                        Console.WriteLine("1.going to the restaurant(a)\n2.train(b)\n3.Sending letter(c)\n4.List of letters(d)\n5.Curriculum(f)\n6.Forest(g)\n7.Scores(h)\n8.Exit(e)");
                        string cs = Console.ReadLine();
                        if (cs[0] == 'a')
                        {
                            if (std[s].Term == 1)
                            {
                                Console.WriteLine("1.Get the curriculum(a)\n2.Get the dormitory code(b)\n3.Group(c)");
                            }
                            else
                            {
                                Console.WriteLine("1.Get the dormitory code(a)\n2.Select unit(b)");
                            }
                        }
                        if (cs[0] == 'b')
                        {

                        }
                        if (cs[0] == 'c')
                        {

                        }
                        if (cs[0] == 'd')
                        {
                            std[s].List_Letters();
                        }
                        if (cs[0] == 'e')
                        {
                            break;
                        }
                    }

                }


                if (c[0] == 'e')
                {
                    break;
                }

            }

            Console.ReadKey();

        }
    }
}
