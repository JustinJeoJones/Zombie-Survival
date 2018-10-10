using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Zombie
    {
        public int maxHp { get; set; }
        public int hp { get; set; }
        public int damage { get; set; }
        public string name { get; set; }
        private Random r = new Random();
        public Zombie()//Default zombie
        {
            maxHp = r.Next(2,11);
            hp = maxHp;
            damage = r.Next(1, 6);
            name = "Zombie";
        }
        public Zombie(Survivor human)//If survivor dies
        {
            maxHp = human.maxHp / 2;
            hp = maxHp;
            damage = human.damage / 2;
            name = "Zombie "+human.name;
        }
        public Zombie(string Name)//Named zombie
        {
            maxHp = r.Next(2, 11);
            hp = maxHp;
            damage = r.Next(1, 6);
            name = "Zombie "+ Name;
        }
        public Zombie(string Name,int Health)//Named zombie with set health
        {
            maxHp = Health;
            hp = maxHp;
            damage = r.Next(1, 6);
            name = "Zombie " + Name;
        }
        public Zombie(string Name, int Health, int dmg)//Named zombie with set health and damage
        {
            maxHp = Health;
            hp = maxHp;
            damage = dmg;
            name = "Zombie " + Name;
        }
    }
}
