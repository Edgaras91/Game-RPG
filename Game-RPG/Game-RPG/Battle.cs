using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_RPG
{
    class Battle
    {




        public void Fight(Character charOne, Character charTwo)
        {
            



            while (charTwo.currentHealth > 0 && charOne.currentHealth > 0)
            {
 
                Console.Clear();
                int damage = charOne.AttackAction();
                Console.WriteLine(charOne.name + " Dealt " + damage + " damage to " + charTwo.name + ".");
                charTwo.currentHealth = charTwo.currentHealth - damage;
                //Displays current health of both parties.
                Console.WriteLine(charOne.name + "'s Health: " + charOne.currentHealth + "/" + charOne.maxHealth + "   |   " + charTwo.name + "'s Health: " + charTwo.currentHealth + "/" + charTwo.maxHealth);

                
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.Read();

            }
            if (charTwo.currentHealth <= 0)
            {
                Console.WriteLine("Right on! You are Victorious!!!");
            }
            else if (charOne.currentHealth <= 0)
            {
                Console.WriteLine("Oh no.. you are dead...");
            }



        }

    }
}
