using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class Roll
    {

        private int[] results;

        public Roll()
        {
            results = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        }


        public int[] diceRoll(int x)
        {
           
            Random rnd = new Random();

            for (int i = 0; i < x; i++)
            {
                results[rnd.Next(1, 7) + rnd.Next(1, 7) - 2] += 1;
            }

            return results;
            
        }
    }
}

