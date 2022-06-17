using System;

namespace Class_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Baku baku = new Baku();
            string answer;
            

            do
            {
                Console.WriteLine("1. isci elave et");
                Console.WriteLine("2. Telebe elave et");
                Console.WriteLine("3. iscilerin sayini gostert");
                Console.WriteLine("4. Telebelerin sayini gostert");
                Console.WriteLine("5. iscilerein siyahsina bax");
                Console.WriteLine("6. Telebelerin siyahsina bax");
                Console.WriteLine("7. Insanlar uzerinden axtaris et");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("secimini edin");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        
                        Console.WriteLine("1.Iscinin adini elave edin: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("2. Iscini soyadini elave edin: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("3. Iscinin yasini elave edin: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("4. Iscinin vezifesini elave edin: ");
                        string position = Console.ReadLine();
                        Employee employee = new Employee(name, surname)
                        {
                            Position = position
                        };
                        baku.AddHuman(employee);
                        break;

                    case "2": 

                        Console.WriteLine("1.Telebenin adini elave edin: ");
                        string namee = Console.ReadLine();
                        Console.WriteLine("2.Telebenin soyadini elave edin: ");
                        string surnamee = Console.ReadLine();
                        Console.WriteLine("3. Telebenin yasini elave edin: ");
                        int agee = int.Parse(Console.ReadLine());
                        Console.WriteLine("4. Telebenin qrup nomresini elave edin: ");
                        string groupNo = Console.ReadLine();
                        Console.WriteLine("5. Telebeninin seviyesini elave ein");
                        string grade = Console.ReadLine();
                        Student student = new Student(namee, surnamee)
                        {
                            GroupNo = groupNo,
                        Grade = grade
                        };

                        baku.AddHuman(student);
                        break;
                    case "3":
                            Console.WriteLine( "iscilerin sayi: "  + baku.GetEmployees().Length);
                        break;

                    case "4":
                        Console.WriteLine( "telebelerin sayo:" + baku.GetStudents().Length);
                        break;
                    case "5":

                       
                    default:
                        break;
                }

            } while (answer != "0");
            
        }
    }
} 







