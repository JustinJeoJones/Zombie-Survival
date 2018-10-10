using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Town
    {
        public string name { get; set; }
        public int danger { get; set; }
        public Town(string Name, int Danger)
        {
            name = Name;
            danger = Danger;
        }
    }
}
