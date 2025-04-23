using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alyssa_Waddell_CPT185_A80H_Final
{
    internal class Critter
    {
        // get and set, declare other things
        public string Name { get; set; }
        public int Age { get; set; }
        public int Hunger { get; set; }
        public int Joy { get; set; }
        public string Type { get; set; }

        // constructor full/overload
        public Critter(string name, string type, int age, int hunger, int joy)
        {
            Name = name;
            Age = age;
            Hunger = hunger;
            Joy = joy;
            Type = type;
        }
        // function to feed critter
        public int Feed(int hunger)
        {
            Random random = new Random();
            int incHunger = random.Next(1, 5); // increase hunger between 1-5 units
            hunger += incHunger;
            if (hunger > 100)
            {
                hunger = 100; // make sure not over 100
            }
            return hunger;
        }
        // function to play w/ critter
        public int Play(int joy)
        {
            Random random = new Random();
            int incJoy = random.Next(1, 5);
            if (joy > 100)
            {
                joy = 100; // make sure to not go over 100
            }    
            joy += incJoy;
            return joy;
        }
    }
}
