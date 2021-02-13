using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _17_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t\t\t Создание ведомости ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t Выберите ваше действие: 1 - Создать файл заново; 2 - Добавить в файл запись; 3 -Посмотреть результаты ");
            Console.Write("\n\tВы выбираете -  ");
            int number = int.Parse(Console.ReadLine());
            string way = @"d://Ведомость.txt";
            Console.ForegroundColor = ConsoleColor.Green;
           
            string line;


            switch (number)
            {
                case 1:
                   


                   
                    string text = "";
                    string name;
                    string surname;
                    string Adres;
                    string otches;
                    string ball;
                    int n = 1;
                    List<string> Out = new List<string>();
                    Console.WriteLine("\t\t\nВведите данные о студентах:");
                    Console.WriteLine("\n");
                    while (n==1)

                    {
                        Console.Write("   Введите Фамилию : ");
                        surname = Console.ReadLine();
                        Console.Write("\n   Введите Имя : ");
                        name = Console.ReadLine();
                        Console.Write("\n   Введите отчество : ");
                        otches = Console.ReadLine();
                        Console.Write("\n   Введите адрес : ");
                        Adres = Console.ReadLine();
                        Console.Write("\n   Введите средний балл: ");
                        ball = Console.ReadLine();
                        text +=  "\n\n"+";"+surname+" "+name+ " " + otches+"; "+Adres+ "; " + ball+";";
                        Out.Add("ФИО :" + surname + " " + name + " " + otches + " Адрес :  " + Adres + " " + "Средний балл :  " + ball) ;
                        Console.WriteLine("\n   Хотите еще ввести данные?   1 - да; 2 - нет ");
                        Console.Write("   Ваш ответ : ");
                       n = int.Parse(Console.ReadLine());
                        

                    }
                    Console.Clear();

                    using (StreamWriter file = new StreamWriter(way, false, System.Text.Encoding.Default))
                    {
                        file.Write(text);
                        
                    }
                    Out.Sort();
                    foreach (string b in Out)
                    {
                        Console.WriteLine("\n  "+b);
                    }
                    using (StreamReader file = new StreamReader(way, System.Text.Encoding.Default))
                    {
                         line = null;
                        string search = "Новосибирск";
                        List<string> Surname = new List<string>();
                        

                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains(search))
                            {
                                string Shablon = @"(4(\.|\,)([5-9]){1}([0-9])*)|((5\.0){1})|(5){1}";
                                Regex regex = new Regex(Shablon);

                                if (regex.IsMatch(line))
                                {
                                    
                                    
                                    
                                    Surname.Add(line);




                                }
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\tФамилии студентов, подходящие под задание:");
                        
                        Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                        Console.WriteLine("{0,0}{1,55}{2,40}{3,40}{4,40}{5,15}{6,4}","|"," Фамилия Имя Отчество","|","Адрес","|","Средний балл","|");
                        Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                      

                        Surname.Sort();

                        foreach (string a in Surname)
                        {
                            if((line = a) != null)
                            {

                                List<string> text_split = line.Split(';').ToList<string>();

                                string FIO = text_split[1];
                                string adres = text_split[2];
                                 ball = text_split[3];

                                Console.WriteLine("{0,0}{1,55}{2,40}{3,40}{4,40}{5,10}{6,9}", "|",  FIO , "|", adres, "|",ball, "|");
                                Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                                text_split.Clear();
                            }

                            
                        } 


                    }
                    break;
                case 2:
                     text = "";
                   
                     n = 1;

                    Console.WriteLine("\t\t\nВведите данные о студентах:");
                    Console.WriteLine("\n");
                    while (n == 1)

                    {
                        Console.Write("   Введите Фамилию : ");
                        surname = Console.ReadLine();
                        Console.Write("\n   Введите Имя : ");
                        name = Console.ReadLine();
                        Console.Write("\n   Введите отчество : ");
                        otches = Console.ReadLine();
                        Console.Write("\n   Введите адрес: ");
                        Adres = Console.ReadLine();
                        Console.Write("\n   Введите средний балл: ");
                        ball = Console.ReadLine();
                        text += "\n\n" + ";" + surname + " " + name + " " + otches + "; " + Adres + "; " + ball + ";";
                       
                        Console.WriteLine("\n   Хотите еще ввести данные?   1 - да; 2 - нет ");
                        Console.Write("   Ваш ответ : ");
                        n = int.Parse(Console.ReadLine());


                    }
                    Console.Clear();

                    using (StreamWriter file = new StreamWriter(way, true, System.Text.Encoding.Default))
                    {
                        file.Write(text);

                    }
                    using (StreamReader file = new StreamReader(way, System.Text.Encoding.Default))
                    {
                        file.Close();

                    }

                    using (StreamReader file = new StreamReader(way, System.Text.Encoding.Default))
                    {
                       
                      while ((  line = file.ReadLine()) != null)

                        {
                           line = line.Trim(';');
                            Console.WriteLine( line);
                        }
             
                     }
                    

                    using (StreamReader file = new StreamReader(way, System.Text.Encoding.Default))
                    {
                        line = null;
                        string search = "Новосибирск";
                        List<string> Surname = new List<string>();
                        

                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains(search))
                            {
                                string Shablon = @"(4(\.|\,)([5-9]){1}([0-9])*)|((5\.0){1})|(5){1}";
                                Regex regex = new Regex(Shablon);

                                if (regex.IsMatch(line))
                                {
                                    


                                    Surname.Add(line);




                                }
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\tФамилии студентов, подходящие под задание:");

                        Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                        Console.WriteLine("{0,0}{1,55}{2,40}{3,40}{4,40}{5,15}{6,4}", "|", " Фамилия Имя Отчество", "|", "Адрес", "|", "Средний балл", "|");
                        Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");


                        Surname.Sort();

                        foreach (string a in Surname)
                        {
                            if ((line = a) != null)
                            {
                               
                                List<string> text_split = line.Split(';').ToList<string>();

                                 string FIO = text_split[1];
                                string  adres = text_split[2];
                                ball = text_split[3];


                                Console.WriteLine("{0,0}{1,55}{2,40}{3,40}{4,40}{5,10}{6,9}", "|", FIO, "|", adres, "|", ball, "|");
                                Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                                text_split.Clear();
                            }


                        }


                    }
                    break;


                case 3:

                    using (StreamReader file = new StreamReader(way, System.Text.Encoding.Default))
                    {

                        while ((line = file.ReadLine()) != null)

                        {
                            line = line.Trim(';');
                            Console.WriteLine(line);
                        }

                    }


                    using (StreamReader file = new StreamReader(way, System.Text.Encoding.Default))
                    {
                        line = null;
                        string search = "Новосибирск";
                        List<string> Surname = new List<string>();


                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains(search))
                            {
                                string Shablon = @"(4(\.|\,)([5-9]){1}([0-9])*)|((5\.0){1})|(5){1}";
                                Regex regex = new Regex(Shablon);

                                if (regex.IsMatch(line))
                                {



                                    Surname.Add(line);




                                }
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\tФамилии студентов, подходящие под задание:");

                        Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                        Console.WriteLine("{0,0}{1,55}{2,40}{3,40}{4,40}{5,15}{6,4}", "|", " Фамилия Имя Отчество", "|", "Адрес", "|", "Средний балл", "|");
                        Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");


                        Surname.Sort();

                        foreach (string a in Surname)
                        {
                            if ((line = a) != null)
                            {

                                List<string> text_split = line.Split(';').ToList<string>();

                                string FIO = text_split[1];
                                string adres = text_split[2];
                                ball = text_split[3];


                                Console.WriteLine("{0,0}{1,55}{2,40}{3,40}{4,40}{5,10}{6,9}", "|", FIO, "|", adres, "|", ball, "|");
                                Console.WriteLine("___________________________________________________________________________________________________________________________________________________________________________________________________");
                                text_split.Clear();
                            }


                        }


                    }




                    break;


            }
          


            Console.ReadLine();

        }
    }
}
