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
                hero.level = 1;
                hero.GetStats();

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
                hero.GetStats();
                
            }


            else
            {
                Console.WriteLine("Ups, that class was invalid.");
                goto classSelect;
                
                


            }

            Console.WriteLine("You wake up, poor, broke, hungry, and you can hear someone calling your name, " + heroName + "...");
            FleeOrAttackOne:
            Console.WriteLine("Before you can react, you are being attacked by a mosquito.");
            Console.WriteLine("You need to make a choice: Flee or Attack?");
            string fleeAttack = Console.ReadLine().ToUpper();
            Console.Clear();



            if (fleeAttack == "FLEE")
            {
                Console.WriteLine("You ran like a little.... Hero.");
            }
            else if (fleeAttack == "ATTACK")
            {
                Console.WriteLine("You attacked like a brave beaver");

                Mosquito mosquito = new Mosquito();
                mosquito.name = "George";
                mosquito.maxHealth = 2;
                mosquito.currentHealth = 1;
                mosquito.attack = 0.1;
                mosquito.exp = 10;
                mosquito.level = 1;
                mosquito.GetStats();

            }
            else
            {
                goto FleeOrAttackOne;
            }












            Console.ReadLine();

        }
    }
}
