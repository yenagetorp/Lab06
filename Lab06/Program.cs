using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("What do you need?");
            var command = Console.ReadLine();
            if (command == "roll d20")
            {
                var diceRoll = rnd.Next(20) + 1;
                Console.WriteLine($"your dice roll was: {diceRoll}");
            }
            if (command == "names")
            {
                var allNames = new[] { "Ben", "Felix", "Elrond", "yen" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            if (command == "Tolkien names")
            {
                var tolkienNames = new[] { "legolas", "Elrond", "Frodo", "Aragaron", "Gandalf" };
                var randomIndex = rnd.Next(tolkienNames.Length);
                Console.WriteLine(tolkienNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
