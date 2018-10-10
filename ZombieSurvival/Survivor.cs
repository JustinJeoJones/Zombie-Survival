using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Survivor
    {
        public string name { get; set; }
        public int maxHp { get; set; }
        public int hp { get; set; }
        public int damage { get; set; }
        public int luck { get; set; }
        Random r = new Random();
        public Survivor()
        {
            name = names[r.Next(0,names.Length)];
            maxHp = 10;
            hp = maxHp;
            damage = 3;
            luck = r.Next(1, 11);
        }
        public Survivor(string Name, int MaxHp, int Damage)
        {
            name = Name;
            maxHp = MaxHp;
            hp = maxHp;
            damage = Damage;
        }

        //Todo, turn this into a file
        private readonly string[] names = {
            "Darrell",
            "Barney",
            "Woodrow",
            "Jewell",
            "Rashad",
            "Bruce",
            "Donovan",
            "Gaston",
            "Oliver",
            "Cristobal",
            "Emil",
            "Darren",
            "Jerrold",
            "Geoffrey",
            "Johnson",
            "Toby",
            "Deon",
            "Hobert",
            "Nelson",
            "Chester",
            " Carman",
            "Tori",
            "Sarita",
            "Krystle",
            "Sook",
            "Sharee",
            "Risa",
            "Georgann",
            "Shaquana",
            "Cecile",
            "Mariette",
            "Cassy",
            "Emely",
            "Reina",
            "Syble",
            "Nickie",
            "Otilia",
            "Karly",
            "Kisha",
            "Nydia"
        };
    }
}
