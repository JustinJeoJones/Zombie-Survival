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
            Console.ForegroundColor = ConsoleColor.DarkGreen;//sets spooky green text
            Console.WriteLine("As the world crumbles to the infected, you wake up");//Intro
            Console.WriteLine("'What is my name?' You think...");
            string name = Console.ReadLine();
            Survivor player = new Survivor(name,10,3); //Player character
            Console.Clear();
            Console.WriteLine($"Ah my name is {player.name}.");

            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}
