using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG
{
    class Inventory
    {


        public List<string> inv = new List<string>();

        public void WriteOut()
        {
            //Inventory.Add("HP Potion");
            inv.ForEach(i => Console.WriteLine("{0}\t", i));
        }




    }
}
