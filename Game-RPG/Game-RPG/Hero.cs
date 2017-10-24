using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG
{
    class Hero
    {
        public string name;
        public int maxHealth;
        public int currentHealth;
        public int attack;
        public int level;
        public int exp;

        public void GetStats()
        {
            Console.WriteLine("Hero name: " + name);
            Console.WriteLine("Hero level: " + level);
            Console.WriteLine("Hero experience: " + exp);
            Console.WriteLine("Hero health: " + currentHealth + "/" + maxHealth);
            Console.WriteLine("Hero attack: " + attack);
          

        }



    }
}
