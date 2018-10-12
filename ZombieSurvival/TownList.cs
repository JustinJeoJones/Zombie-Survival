using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class TownList
    {
        List<Town> towns = new List<Town>();
        Random r = new Random();
        public TownList()
        {
            towns.Add(new Town("Main city", 5)); //(name, difficulty)
            towns.Add(new Town("Hospital", 4));
            towns.Add(new Town("Side city", 3));
            towns.Add(new Town("Small city", 2));
            towns.Add(new Town("Forest", 1));
            towns.Add(new Town("Mall",3));
            towns.Add(new Town("Beach", 1));
            towns.Add(new Town("Cave", 0));
            towns.Add(new Town("School", 2));
            towns.Add(new Town("Office", 2));
        }
        public Town GetRandomTown()
        {
            Town result;
            
            result = towns[r.Next(0, towns.Count)];
            return result;
        }
        public Town GetNewTown(Town input)
        {
            Town Result;
            do
            {
                Result = towns[r.Next(0, towns.Count)];
            } while (input == Result);
            return Result;
        }
        public Town GetTownBasedOnDifficulty(int dif)
        {
            List<Town> townList = new List<Town>();

            towns.ForEach(x =>
            {
                if (x.danger == dif)
                {
                    townList.Add(x);
                }
            });

            return townList[r.Next(0, townList.Count)];
        }
        public Town buildTown(string name,int difficulty)
        {
            Town result = new Town(name,difficulty);
            towns.Add(result);
            return result;
        }
    }
}
