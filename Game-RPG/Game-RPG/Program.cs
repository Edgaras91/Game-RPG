using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome, please type in your hero name:");
            string heroName = Console.ReadLine();
            Console.WriteLine("Allright, " + heroName + " it is then.");
            Console.WriteLine("Now please type your class from the following: ");
            Console.WriteLine("Warrior / Ranger");

            string heroClassCheck = Console.ReadLine().ToUpper();

           
            string warrior = "WARRIOR";
            string ranger = "RANGER";

            if (heroClassCheck == warrior)
            {
                Console.WriteLine("Warrior - Can withstand a punch");
                Hero hero = new Hero();
                hero.name = heroName;
                hero.maxHealth = 10;
                hero.currentHealth = 10;
                hero.attack = 2;
                hero.exp = 1;

            }
            else if (heroClassCheck == ranger)
            {
                Console.WriteLine("Ranger - Stealthy and deadly!");
            }


            else
            {
                Console.WriteLine("Ups, that class was invalid.");
                
            }


            Console.ReadLine();
        }
    }
}
