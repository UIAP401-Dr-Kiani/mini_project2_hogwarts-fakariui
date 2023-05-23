using System;
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
            int tchek = 0;
            int schek = 0;
            int train = 0;
            DateTime date= DateTime.Now;
            Lesson physic = new Lesson();
            Lesson math = new Lesson();
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
                        Console.WriteLine("1.Send arrival letter and train ticket(a)\n2.List of letters(b)\n3.Send a return tickets(c)\n4.Completing the curriculum(d)\n5.Curriculum for first semester students(f)\n6.Garden(g)\n7.Add the plant(h)\n8.Exit(e)");
                        string cd = Console.ReadLine();
                        if (cd[0] == 'a')
                        {
                            for (int i = 0; i < std.Length; i++)
                            {
                                std[i].letters.Add(dombeldor.entry());
                                dombeldor.ticket(std, i);
                            }
                            Console.WriteLine("Letters have been sent successfully");
                        }
                        if (cd[0] == 'b')
                        {
                            dombeldor.List_Letters();
                        }
                        if (cd[0] == 'c')
                        {
                            dombeldor.return_ticket(ys, std);
                        }
                        if (cd[0] == 'd')
                        {
                            dombeldor.Completing_curriculum(yt, tch, dombeldor);
                        }
                        if (cd[0] == 'f')
                        {
                            dombeldor.select_unit1(dombeldor, std, ys);
                        }
                        if (cd[0] == 'g')
                        {
                            Phytology phy = new Phytology();
                            Console.WriteLine("Specify the name and number of plants for each term");
                            Console.WriteLine("the first semester plants:");
                            dombeldor.garden1(phy);
                            Console.WriteLine("the second semester plants:");
                            dombeldor.garden2(phy);
                            Console.WriteLine("the third semester plants:");
                            dombeldor.garden3(phy);
                            ; Console.WriteLine("the fourth semester plants:");
                            dombeldor.garden4(phy);
                        }
                        if (cd[0] == 'h')
                        {
                            Phytology phy = new Phytology();
                            Console.WriteLine("1.the first semester 2.the second semester 3.the third semester 4.the fourth semester");
                            int cdh = Convert.ToInt32(Console.ReadLine());
                            if (cdh == 1)
                            {
                                dombeldor.garden1(phy);
                            }
                            if (cdh == 2)
                            {
                                dombeldor.garden2(phy);
                            }
                            if (cdh == 3)
                            {
                                dombeldor.garden3(phy);
                            }
                            if (cdh == 4)
                            {
                                dombeldor.garden4(phy);
                            }
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
                        Console.WriteLine("enter your lastname:");
                        string lastname = Console.ReadLine();
                        for (int i = 0; i < yt; i++)
                        {
                            if (tch[i].lastname == lastname)
                            {
                                t = i;
                                while (1 == 1)
                                {
                                    Console.Write("Enter username:");
                                    string username1 = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Enter password:");
                                    string password1 = Console.ReadLine();
                                    Console.WriteLine();
                                    if (tch[t].username == username1 && tch[t].password == password1)
                                    {
                                        Console.WriteLine("correct!");
                                        w = 1;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("incorrect,pleas enter again!");
                                    }

                                }
                                if (w == 1)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (i == yt - 1)
                                {
                                    Console.WriteLine("The person not found!");
                                }
                            }
                        }
                        if (w == 1)
                        {
                            break;
                        }
                    }
                    if (tchek == 0)
                    {
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
                        tchek++;
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
                        Console.WriteLine("enter your lastname:");
                        string lastname1 = Console.ReadLine();
                        for (int i = 0; i < ys; i++)
                        {
                            if (std[i].lastname == lastname1)
                            {
                                s = i;
                                while (1 == 1)
                                {
                                    Console.Write("Enter username:");
                                    string username1 = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Enter password:");
                                    string password1 = Console.ReadLine();
                                    Console.WriteLine();
                                    if (std[s].username == username1 && std[s].password == password1)
                                    {
                                        Console.WriteLine("correct!");
                                        q = 1;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("incorrect,pleas enter again!");
                                    }

                                }
                                if (q == 1)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                if (i == ys - 1)
                                {
                                    Console.WriteLine("The person not found!");
                                }
                            }
                        }
                        if (q == 1)
                        {
                            break;
                        }
                    }
                    if (schek == 0)
                    {
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
                        schek++;
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
