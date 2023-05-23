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
                        Console.WriteLine("1.Choose lesson with time(a)\n2.List of lessons(b)\n3.Exit(e)");
                        string ct = Console.ReadLine();
                        if (ct[0] == 'a')
                        {
                            tch[t].Chooselesson(tch, t);
                        }
                        if (ct[0] == 'b')
                        {
                            tch[t].List_lessons(tch, t);
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
                            Group gr = new Group();
                            Console.WriteLine("What is your group?\n1.Hufflepuff(a)\n2.Gryffindor(b)\n3.Ravenclaw(c)\n4.Slytherin(d)");
                            string answer2 = Console.ReadLine();
                            if (answer2[0] == 'a')
                            {
                                std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Hufflepuff", true);
                                gr.group_Hufflepuff.Add(std[s]);
                            }
                            if (answer2[0] == 'b')
                            {
                                std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Gryffindor", true);
                                gr.group_Gryffindor.Add(std[s]);
                            }
                            if (answer2[0] == 'c')
                            {
                                std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Ravenclaw", true);
                                gr.group_Ravenclaw.Add(std[s]);
                            }
                            if (answer2[0] == 'd')
                            {
                                std[s].group.type1 = (Group.Type1)Enum.Parse(typeof(Group.Type1), "Slytherin", true);
                                gr.group_Slytherin.Add(std[s]);
                            }

                        }
                        schek++;
                    }
                    while (1 == 1)
                    {
                        Console.WriteLine("1.going to the restaurant(a)\n2.train(b)\n3.Sending a letter to return(c)\n4.List of letters(d)\n5.Curriculum(f)\n6.Scores(h)\n7.Exit(e)");
                        string cs = Console.ReadLine();
                        if (train != 0)
                        {


                            if (cs[0] == 'a')
                            {
                                int dsm = 0;
                                int dsw = 0;
                                Dorm.Code();
                                for (int d = 0; d < ys; d++)
                                {
                                    if (std[d].gender == "female")
                                    {
                                        std[d].NumberofDorm = Dorm.Women_dormitory[dsw];
                                        dsw++;
                                    }
                                    if (std[d].gender == "male")
                                    {
                                        std[d].NumberofDorm = Dorm.Men_dormitory[dsm];
                                        dsm++;
                                    }
                                }
                                if (std[s].Term == 1)
                                {
                                    while (1 == 1)
                                    {


                                        Console.WriteLine("1.Get the curriculum(a)\n2.Get the dormitory code(b)\n3.Group(c)\n4.Exit(e)");
                                        string cst1 = Console.ReadLine();
                                        if (cst1[0] == 'a')
                                        {
                                            std[s].Get_Curriculum(std, s);
                                        }
                                        if (cst1[0] == 'b')
                                        {

                                            Console.WriteLine($"Your dorm code is {std[s].NumberofDorm}");
                                        }
                                        if (cst1[0] == 'c')
                                        {

                                            std[s].rand_group(std, s);
                                        }
                                        if (cst1[0] == 'e')
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    while (1 == 1)
                                    {

                                        Console.WriteLine("1.Get the dormitory code(a)\n2.Select unit(b)\n3.Exit(e)");
                                        string cst2 = Console.ReadLine();
                                        if (cst2[0] == 'a')
                                        {

                                            Console.WriteLine($"Your dorm code is {std[s].NumberofDorm}");
                                        }
                                        if (cst2[0] == 'b')
                                        {
                                            int nl = 0;
                                            Console.WriteLine("Choose lessons");
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
                                            if (std[s].Term == 2)
                                            {
                                                for (int i = 0; i < dombeldor.Lesson2.Count; i++)
                                                {
                                                    Console.WriteLine($"{i} - Name of teacher:{dombeldor.Lesson2[i].name_teacher} - Name of Lessons:{dombeldor.Lesson2[i].Name} - Day:{dombeldor.Lesson2[i].day} - Time:{dombeldor.Lesson2[i].Time} - Capacity:{dombeldor.Lesson2[i].Capacity}");
                                                    dombeldor.Lesson2[i].Code = 20 + i;
                                                }
                                                std[s].Select_Unite2(std, dombeldor, s, nl);
                                                for (int u = 0; u < std[s].Lessons.Count; u++)
                                                {
                                                    for (int h = 0; h < yt; h++)
                                                    {
                                                        if (tch[h].lastname == std[s].Lessons[u].name_teacher)
                                                        {
                                                            for (int l = 0; l < tch[h].Lessons.Count; l++)
                                                            {
                                                                if (tch[h].Lessons[l].Name == std[s].Lessons[u].Name)
                                                                {
                                                                    tch[h].Lessons[l].students.Add(std[s]);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (std[s].Term == 3)
                                            {
                                                for (int i = 0; i < dombeldor.Lesson3.Count; i++)
                                                {
                                                    Console.WriteLine($"{i} - Name of teacher:{dombeldor.Lesson3[i].name_teacher} - Name of Lessons:{dombeldor.Lesson3[i].Name} - Day:{dombeldor.Lesson3[i].day} - Time:{dombeldor.Lesson3[i].Time} - Capacity:{dombeldor.Lesson3[i].Capacity}");
                                                    dombeldor.Lesson3[i].Code = 30 + i;
                                                }
                                                std[s].Select_Unite3(std, dombeldor, s, nl);
                                            }
                                            if (std[s].Term == 4)
                                            {
                                                for (int i = 0; i < dombeldor.Lesson4.Count; i++)
                                                {
                                                    Console.WriteLine($"{i} - Name of teacher:{dombeldor.Lesson4[i].name_teacher} - Name of Lessons:{dombeldor.Lesson4[i].Name} - Day:{dombeldor.Lesson4[i].day} - Time:{dombeldor.Lesson4[i].Time} - Capacity:{dombeldor.Lesson4[i].Capacity}");
                                                    dombeldor.Lesson4[i].Code = 40 + i;
                                                }
                                                std[s].Select_Unite4(std, dombeldor, s, nl);
                                            }

                                        }
                                        if (cst2[0] == 'e')
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        if (cs[0] == 'b')
                        {
                            if (date == std[s].dts)
                            {
                                Console.WriteLine("You can take the train");
                                train = 1;
                            }
                            else
                            {
                                Console.WriteLine("Please wait until the train arrives");
                            }
                        }
                        if (train != 0) 
                        { 
                        if (cs[0] == 'c')
                        {
                            dombeldor.letters.Add(std[s].Return_Letter(std, s));
                            Console.WriteLine("Letter has been sent successfully");
                        }
                        }
                        if (cs[0] == 'd')
                        {
                            std[s].List_Letters();
                        }
                        if (train != 0) 
                        { 
                        if (cs[0] == 'f')
                        {
                            while (1 == 1)
                            {
                                Console.WriteLine("choose lesson:");
                                std[s].Curriculum(std, s);
                                Console.WriteLine("Exit(5)");
                                string e = Console.ReadLine();
                                int ecod = Convert.ToInt32(e);
                                if (ecod == 5)
                                {
                                    break;
                                }
                                for (int i = 0; i < std[s].Lessons.Count; i++)
                                {
                                    if (ecod == std[s].Lessons[i].Code)
                                    {
                                        while (1 == 1)
                                        {
                                            Console.WriteLine("a.exercise  b.scores");
                                            string e1 = Console.ReadLine();
                                            if (e1[0] == 'a')
                                            {
                                                if (std[s].Lessons[i].Name == "phytology")
                                                {
                                                    for (int f = 0; f < std[s].spractice.Count; f++)
                                                    {
                                                        Console.WriteLine(std[s].spractice[f]);
                                                    }
                                                    Console.WriteLine("---------------------------------------");
                                                    Phytology phy = new Phytology();
                                                    int tc = 0;
                                                    for (int t = 0; t < yt; t++)
                                                    {
                                                        if (std[s].Lessons[i].name_teacher == tch[t].lastname)
                                                        {
                                                            tc = t;
                                                        }
                                                    }
                                                    Console.WriteLine("please go to the forest and do the exercise.\nGarden(a)");
                                                    string grd = Console.ReadLine();
                                                    if (grd[0] == 'a')
                                                    {
                                                        Console.WriteLine("---------------------------------------");
                                                        for (int n = 0; n < phy.plant1.Count; n++)
                                                        {
                                                            Console.WriteLine($"name={phy.plant1[n].Name}  number={phy.plant1[n].Number}");
                                                        }
                                                        for (int n = 0; n < phy.plant2.Count; n++)
                                                        {
                                                            Console.WriteLine($"name={phy.plant2[n].Name}  number={phy.plant2[n].Number}");
                                                        }
                                                        for (int n = 0; n < phy.plant3.Count; n++)
                                                        {
                                                            Console.WriteLine($"name={phy.plant3[n].Name}  number={phy.plant3[n].Number}");
                                                        }
                                                        for (int n = 0; n < phy.plant4.Count; n++)
                                                        {
                                                            Console.WriteLine($"name={phy.plant4[n].Name}  number={phy.plant4[n].Number}");
                                                        }
                                                        Console.WriteLine("---------------------------------------");
                                                    }
                                                    while (1 == 1)
                                                    {
                                                        Console.WriteLine("Request to add a plant(a)  Send exercise(b)  Exit(e)");
                                                        string aq = Console.ReadLine();
                                                        if (aq[0] == 'a')
                                                        {
                                                            Console.WriteLine("name:");
                                                            string nameps = Console.ReadLine();
                                                            dombeldor.letters.Add($"Hello!I am{std[s].lastname}.Please add the {nameps} plant in the forest.");
                                                            Console.WriteLine("done successfully");
                                                        }
                                                        if (aq[0] == 'b')
                                                        {
                                                            Console.WriteLine("How many types of plants should you choose?");
                                                            int numps = Convert.ToInt32(Console.ReadLine());

                                                            for (int u = 0; u < numps; u++)
                                                            {
                                                                Console.WriteLine("name:");
                                                                string nameps = Console.ReadLine();
                                                                Console.WriteLine("number:");
                                                                int numberps = Convert.ToInt32(Console.ReadLine());
                                                                tch[tc].tpractice.Add($"name of student:{std[s].lastname}  name:{nameps}  number:{numberps}");
                                                            }
                                                            Console.WriteLine("Submitted successfully");
                                                        }
                                                        if (aq[0] == 'e')
                                                        {
                                                            break;
                                                        }
                                                    }

                                                }

                                            }
                                            if (e1[0] == 'b')
                                            {
                                                for (int a = 0; a < std[s].Lessons.Count; a++)
                                                {
                                                    Console.WriteLine(std[s].Lessons[i].scores[a]);
                                                }
                                            }
                                            if (e1[0] == 'e')
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
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
