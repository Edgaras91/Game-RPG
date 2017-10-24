using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_RPG
{
    class Program

    {
        static void Help()
        {
            Console.WriteLine("Following commands are available:");
            Console.WriteLine("/stats");


        }





        static public void Main()
        {

            Start:
            Console.WriteLine("Welcome, please type in your hero name:");
            string heroName = Console.ReadLine();
            Console.WriteLine("Are you sure?");
            string confirm = Console.ReadLine().ToUpper();
            if ( confirm == "NO")
            {
                Console.Clear();
                goto Start;
            }
            else if (confirm == "N")
            {
                Console.Clear();
                goto Start;

            }
            

                Console.Clear();
            Console.WriteLine("Allright, " + heroName + " it is then.");
            Thread.Sleep(2000);




            classSelect:
            Console.WriteLine("Please type your class from the following: ");
            Console.WriteLine("Warrior / Ranger");
            

            string heroClassCheck = Console.ReadLine().ToUpper();
            Console.Clear();
            


            if (heroClassCheck == "WARRIOR")
            {
                Console.WriteLine("Warrior - Can withstand a punch");
                Hero hero = new Hero();
                hero.name = heroName;
                hero.maxHealth = 10;
                hero.currentHealth = 10;
                hero.attack = 2;
                hero.exp = 1;

                Inventory inv = new Inventory();
                inv.smallPotions = 2;


            }
            else if (heroClassCheck == "RANGER")
            {
                Console.WriteLine("Ranger - Stealthy and deadly!");
                Hero hero = new Hero();
                hero.name = heroName;
                hero.maxHealth = 5;
                hero.currentHealth = 5;
                hero.attack = 7;
                hero.level = 1;
                hero.exp = 1;
            }


            else
            {
                Console.WriteLine("Ups, that class was invalid.");
                goto classSelect;


            }



            //Hero hero = hero.GetStats;



            Console.ReadLine();

        }
    }
}
