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
        //Help() is not in use yet
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
            //Initialisation Start
            Inventory inv = new Inventory();
            Character hero = new Character();
            //Initialisation End
            inv.inv.Add("HP Potion");
            inv.WriteOut();


            Start:
            Console.WriteLine("Welcome, please type in your hero name:");
            string heroName = Console.ReadLine();
            if (string.IsNullOrEmpty(heroName)) { goto Start; }
            heroName = heroName.First().ToString().ToUpper() + heroName.Substring(1).ToString().ToLower();
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
                inv.inv.Add("Hp Potion");
                





            }
            else if (heroClassCheck == "RANGER")
            {
                Console.WriteLine("Ranger - Stealthy and deadly!");
                hero.name = heroName;
                hero.maxHealth = 5;
                hero.currentHealth = 5;
                hero.attack = 7;
                hero.level = 1;
                hero.exp = 1;
                inv.inv.Add("Hp Potion");
                inv.inv.Add("Hp Potion");

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
            Thread.Sleep(2000);
            Console.WriteLine("Before you can react, you are being attacked by a mosquito!");
            Thread.Sleep(2000);
            Character mosquito = new Character();

            mosquito.name = "George";
            mosquito.maxHealth = 20;
            mosquito.currentHealth = 20;
            mosquito.attack = 1;
            mosquito.exp = 10;
            mosquito.level = 1;
            mosquito.AnnounceAllStats();

            FightOrFlight fightOne = new FightOrFlight();
            fightOne.Fight(hero, mosquito);

            //End of program
            Console.WriteLine("You reached the end.");
            Console.Read();
        }              
    }
}
