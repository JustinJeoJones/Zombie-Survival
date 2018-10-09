using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Survivor
    {
        string name { get; set; }
        int maxHp { get; set; }
        int hp { get; set; }
        int damage { get; set; }
        int luck { get; set; } 

        public Survivor()
        {
            name = "James Bean";
            maxHp = 10;
            hp = maxHp;
            damage = 3;
            Random randm = new Random():
            luck = randm.Next(1, 11);
        }
        public Survivor(string Name, int MaxHp, int Damage)
        {
            name = Name;
            maxHp = MaxHp;
            hp = maxHp;
            damage = Damage;
        }
    }
}
