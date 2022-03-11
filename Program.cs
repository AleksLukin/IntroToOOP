
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntroToOOP
{
    class Program : FootbalMan
    {
        static void Main(string[] args)
        {
            FootbalMan.Career();
            FootbalMan.FootballClub();
            FootbalMan.Position();
        }
    }
    class FootbalMan
    {
        private uint age { get; set; }
        private string club { get; set; }
        private uint goal { get; set; }

        public static void Career()
        {
            FootbalMan footbalMan = new();

            Console.WriteLine("Please, input age of a footbalman");
            footbalMan.age = uint.Parse(Console.ReadLine());

            if (footbalMan.age < 40 && footbalMan.age > 18)
            {
                Console.WriteLine("It`s a really footballman");
            }
            else
            {
                Console.WriteLine("He`s not a really footbalman");
            }
        }
        public static void FootballClub()
        {
            FootbalMan footbalMan = new();

            Console.WriteLine("Please, input club of play");

            footbalMan.club = Console.ReadLine();
        }
        public static void Position()
        {
            FootbalMan footbalMan = new();

            Console.WriteLine("Please, input quantity of goals");

            footbalMan.goal = uint.Parse(Console.ReadLine());

            if (footbalMan.goal < 20 && footbalMan.goal > 10)
            {
                Console.WriteLine("It`s a midfielder");
            }
            else if (footbalMan.goal < 10 && footbalMan.goal > 0)
            {
                Console.WriteLine("It`s a defender");
            }
            else
            {
                Console.WriteLine("It`s a forward!");
            }
        }
    }
}
