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

        public void PressAnyKey()
        {
            Console.WriteLine("Press any key to Continue");
            Console.Read();
            Console.Clear();
        }

        static public void Main()
        {
            //Initialisation
            Character hero = new Character();
            

            Start:
            Console.WriteLine("Welcome, please type in your hero name:");
            string heroName = Console.ReadLine();
            Console.WriteLine("Are you sure?");
            string confirm = Console.ReadLine().ToUpper();
            if (confirm == "NO")
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
                Console.WriteLine("Warrior - Can withstand a punch!");
                Thread.Sleep(1000);


                hero.name = heroName;
                hero.maxHealth = 10;
                hero.currentHealth = 10;
                hero.attack = 2;
                hero.exp = 1;
                hero.level = 1;


                Inventory inv = new Inventory();
                inv.smallPotions = 2;


            }
            else if (heroClassCheck == "RANGER")
            {
                Console.WriteLine("Ranger - Stealthy and deadly!");
                Thread.Sleep(1000);


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

            hero.AnnounceAllStats();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You wake up, poor, broke, hungry, and you can hear someone calling your name, " + heroName + "...");
            Thread.Sleep(5000);
            Console.WriteLine("Before you can react, you are being attacked by a mosquito!");
            Thread.Sleep(5000);
            Character mosquito = new Character();

            mosquito.name = "George";
            mosquito.maxHealth = 20;
            mosquito.currentHealth = 20;
            mosquito.attack = 1;
            mosquito.exp = 10;
            mosquito.level = 1;
            mosquito.AnnounceAllStats();







            FightOrFlight();


            void FightOrFlight()
            {
                string fleeAttack;
                FleeOrAttackOne:
                Console.WriteLine("You need to make a choice: Flee or FIGHT?");
                fleeAttack = Console.ReadLine().ToUpper();
                Console.Clear();
                if (fleeAttack == "FLEE")
                {
                    Console.WriteLine("You ran like a little.... Hero.");
                }


                else if (fleeAttack == "FIGHT")
                {
                    Console.WriteLine("Let the battle Begin!.. How excaiting...");
                    Thread.Sleep(5000);
                    
                    Battle();
                }
                else
                {
                    goto FleeOrAttackOne;
                }
            }


            void Battle()
            {
                void CurrentHealth ()
                {
                    Console.WriteLine(hero.name + "'s Health: " + hero.currentHealth + "/" + hero.maxHealth + "   |   " + mosquito.name + "'s Health: " + mosquito.currentHealth + "/" + mosquito.maxHealth);
                }
                void Attack()
                {
                    Console.WriteLine(hero.name + " Dealt " + hero.attack + " damage to " + mosquito.name + ".");
                }





                while (mosquito.currentHealth > 0 && hero.currentHealth > 0)
                {
                    Console.Clear();
                    
                    Attack();
                    mosquito.currentHealth = mosquito.currentHealth - hero.attack;
                    CurrentHealth();

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.Read();
                    


                }
                if (mosquito.currentHealth <= 0)
                {
                    Console.WriteLine("Right on! You are Victorious!!!");
                }
                else if (hero.currentHealth <= 0)
                {
                    Console.WriteLine("Oh no.. you are dead...");
                }
                else
                {
                    Console.WriteLine("You reached the end.");
                }
            }
                

         Console.Read();

            
        }
    }
}
