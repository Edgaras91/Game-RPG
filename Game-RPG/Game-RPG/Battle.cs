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
                int damageCharOne = charOne.AttackAction();
                Console.WriteLine("Now it's " + charOne.name + "'s turn. Press any key to continue.");
                Console.Read();
                Console.WriteLine(charOne.name + " Dealt " + damageCharOne + " damage to " + charTwo.name + ".");
                charTwo.currentHealth = charTwo.currentHealth - damageCharOne;
                //Displays current health of both parties.
                Console.WriteLine(charOne.name + "'s Health: " + charOne.currentHealth + "/" + charOne.maxHealth + "   |   " + charTwo.name + "'s Health: " + charTwo.currentHealth + "/" + charTwo.maxHealth);
               // Console.WriteLine("Turn ended. Press any key to continue.");
               // Console.Read();
               // Console.WriteLine();
                ///////////////////////////////////////////////CharTwo turn///////////////////////////////////////
                int damageCharTwo = charTwo.AttackAction();

                Console.WriteLine("Now it's " + charTwo.name + "'s turn. Press any key to continue.");
                Console.Read();
                Console.WriteLine(charTwo.name + " Dealt " + damageCharTwo + " damage to " + charOne.name + ".");
                charOne.currentHealth = charOne.currentHealth - damageCharOne;
                //Displays current health of both parties.
                Console.WriteLine(charOne.name + "'s Health: " + charOne.currentHealth + "/" + charOne.maxHealth + "   |   " + charTwo.name + "'s Health: " + charTwo.currentHealth + "/" + charTwo.maxHealth);
               // Console.WriteLine("Turn ended. Press any key to continue.");
               // Console.Read();
               // Console.WriteLine();








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
