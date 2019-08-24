using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{

    struct Person
    {
        int age;
        string name;
        string character;
        string idea;
        string friend;

        public Person(string name, int age, string character, string idea, string friend)
        {
            this.age = age;
            this.name = name;
            this.character = character;
            this.idea = idea;
            this.friend = friend;
        }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine($"Age is: {age}");
            Console.WriteLine($"Character is: {character}");
            Console.WriteLine($"Friendly: {friend}");
            Console.WriteLine($"User think about: {idea}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Создание персонажа");
            Console.WriteLine("NickName:");
            string name = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Character:");
            string character = Console.ReadLine();
            Console.WriteLine("I think about:");
            string idea = Console.ReadLine();
            Console.WriteLine("Friendly?");
            string friend = Console.ReadLine();

            Person User1 = new Person ( name, age, character, idea, friend );
            Person User2 = new Person("RioSan", 14, "SportMan", "I find animeTyn", "I love you)*");
            Person User3 = new Person("Senmpai", 24, "Anime", "I hit you", "Yes");
            Person User4 = new Person("Mahich", 19, "Hit", "I love hit Ivan", "Yeah");
            Person User5 = new Person("Lolita",16,"CyberSport", "I love eating", "Hi, american)*");

            Console.WriteLine("Познакомиться с другими персонажами?");
            string answer = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("                                     Ваша анкета: ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            User1.Display();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
