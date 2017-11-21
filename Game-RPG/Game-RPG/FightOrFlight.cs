using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_RPG
{
    class FightOrFlight
    {
        public void Fight(Character charOne, Character charTwo)
        {
            
            string fleeAttack;
            FleeOrAttackOne:
            Console.WriteLine("You need to make a choice: Flee or Fight?");
            fleeAttack = Console.ReadLine().ToUpper();
            Console.Clear();
            if (fleeAttack == "FLEE")
            {
                Console.WriteLine("You ran like a little.... Hero.");
                Thread.Sleep(2000);
            }
            else if (fleeAttack == "FIGHT")
            {
                Console.WriteLine("Let the battle Begin!.. How excaiting...");
                Thread.Sleep(2000);
                Battle fightOne = new Battle();
                Battle battle = new Battle();
                battle.Fight(charOne, charTwo);

            }
            else
            {
                goto FleeOrAttackOne;
            }

        }
    }
}
