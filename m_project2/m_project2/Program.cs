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
            Admin dombeldor = new Admin();
            Allowed_Human[] ah = new Allowed_Human[500];
            Student[] std = new Student[500];
            Teacher[] tch = new Teacher[500];
            using (StreamReader file = new StreamReader("file.tsv"))
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
                    ah[m].firstname = human[0];
                    ah[m].lastname = human[1];
                    ah[m].dateofbirth=human[2];
                    ah[m].gender = human[3];
                    ah[m].father = human[4];
                    ah[m].username = human[5];
                    ah[m].password = human[6];
                    ah[m].racetype =(Human.Racetype) Enum.Parse(typeof(Human.Racetype),human[7],true);
                    ah[m].role = (Allowed_Human.Role)Enum.Parse(typeof(Allowed_Human.Role),human[8],true);
                    m++;
                }
                file.Close();
            }

            Console.ReadKey();
            int j = 0;
            for (int i = 0; i < ah.Length; i++)
            {
                if ((int)ah[i].role == 1)
                {
                    std[j].firstname = ah[i].firstname;
                    std[j].lastname = ah[i].lastname;
                    std[j].dateofbirth = ah[i].dateofbirth;
                    std[j].gender = ah[i].gender;
                    std[j].father = ah[i].father;
                    std[j].username = ah[i].username;
                    std[j].password = ah[i].password;
                    std[j].racetype = ah[i].racetype;
                    j++;
                }
            }
            for (int i = 0; i < ah.Length; i++)
            {
                if ((int)ah[i].role == 0)
                {
                    tch[j].firstname = ah[i].firstname;
                    tch[j].lastname = ah[i].lastname;
                    tch[j].dateofbirth = ah[i].dateofbirth;
                    tch[j].gender = ah[i].gender;
                    tch[j].father = ah[i].father;
                    tch[j].username = ah[i].username;
                    tch[j].password = ah[i].password;
                    tch[j].racetype = ah[i].racetype;
                    j++;
                }
            }

            while (1 == 1)
            {
                Console.WriteLine("Choose one:");
                Console.WriteLine("a)dombeldor\nb)teacher\nc)student");
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
                        Console.WriteLine("1.Sending letter(a)\n2.List of letters(b)\n3.Send train tickets(c)\n4.Curriculum for first semester students(d)\n5.Gardening(f)\n6.Exit(e)");
                        string cd = Console.ReadLine();
                        if (cd[0] == 'a')
                        {
                            for (int i = 0; i < std.Length; i++)
                            {
                                std[i].Letter[0] = dombeldor.entry();//////////////
                            }
                            Console.WriteLine("Letters have been sent successfully");
                        }
                        if (cd[0] == 'b')
                        {
                            for (int i = 0; i < dombeldor.Letter.Length; i++)
                            {
                                Console.WriteLine(dombeldor.Letter[i]);
                            }
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
                        if (cd[0] == 'e')
                        {
                            break;
                        }
                    }

                }
                if (c[0] == 'b')
                {
                    int t = 0;
                    while (1 == 1)
                    {
                        Console.Write("Enter username:");
                        string username1 = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter password");
                        string password1 = Console.ReadLine();
                        Console.WriteLine();

                        for (int i = 0; i < tch.Length; i++)
                        {
                            if (tch[i].username == username1 && tch[i].password == password1)
                            {
                                Console.WriteLine("correct!");
                                t = i;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("incorrect,pleas enter again!");
                            }
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









            }



        }
    }
}
