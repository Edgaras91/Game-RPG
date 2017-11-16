using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_RPG
{
    class static Hero
    {
        public string name;
        public int maxHealth;
        public int currentHealth;
        public int attack;
        public int level;
        public int exp;
        
        
        public void AnnounceStats (all, name, level, exp, currentHealth, maxHealth, attack)
        
        

        public void AnnounceAllStats()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hero name: " + name);
            Thread.Sleep(500);
            Console.WriteLine("Hero level: " + level);
            Thread.Sleep(500);
            Console.WriteLine("Hero experience: " + exp);
            Thread.Sleep(500);
            Console.WriteLine("Hero health: " + currentHealth + "/" + maxHealth);
            Thread.Sleep(500);
            Console.WriteLine("Hero attack: " + attack);
          

        }



    }
}
