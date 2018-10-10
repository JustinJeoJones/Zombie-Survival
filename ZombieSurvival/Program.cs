using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.ForegroundColor = ConsoleColor.DarkGreen;//sets spooky green text
            Console.WriteLine("As the world crumbles to the infected, you wake up");//Intro
            Console.WriteLine("'What is my name?' You think...");
            string name = Console.ReadLine();
            Survivor player = new Survivor(name,10,3); //Player character
            Console.Clear();
            Console.WriteLine($"Ah my name is {player.name}.");
            clearCon();

            Console.WriteLine("While trying to gather my thoughts, I notice a group of zombies heading towards my direction.");
            Console.WriteLine($"Looks like there are {r.Next(5, 101)} zombies moving my direction.");
            Console.WriteLine("Almost out of fear I instinctively run away.");
            clearCon();
            

            Console.WriteLine("After running for who knows how long, I end up in a remote area.");
            Console.WriteLine("I decide to stay here and set up camp.");
            clearCon();
            //end of intro / start of game
            bool menuLoop = true;
            int Aggro = player.luck;
            int day = 0;
            while (menuLoop)
            {
                Console.WriteLine($"Day {day}.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1.Scavenge locally");
                Console.WriteLine("2.Scavenge nearby");
                Console.WriteLine("3.Look for survivors");
                Console.WriteLine("4.Look for zombies");
                Console.WriteLine("5.Rest");
                clearCon();
                day++;
            }

            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
        static void clearCon()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
