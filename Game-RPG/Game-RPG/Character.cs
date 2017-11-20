using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_RPG
{
    public class  Character
    {
        
        public string name;
        public int maxHealth;
        public int currentHealth;
        public int attack;
        public int level;
        public int exp;
        
        
        
        
        

        public void AnnounceAllStats()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Following are the stats:");
            Thread.Sleep(1000);
            Console.WriteLine("Name: " + name);
            Thread.Sleep(500);
            Console.WriteLine("Level: " + level);
            Thread.Sleep(500);
            Console.WriteLine("Experience: " + exp);
            Thread.Sleep(500);
            Console.WriteLine("Health: " + currentHealth + "/" + maxHealth);
            Thread.Sleep(500);
            Console.WriteLine("Attack: " + attack);
            Thread.Sleep(500);
            Console.WriteLine();
            


        }



    }
}
