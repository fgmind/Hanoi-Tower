using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTower
{
    class HanoiTower        //class containing method to move discs from 1 peg to the other
    {
     
        public void moveDiscs(int n, String a, String b, String c)
        {
            if (n == 1)
            {
                Console.WriteLine("Move Disc from " + a + " to " + b);
            }
            else
            {
                moveDiscs(n - 1, a, c, b);                              // reloads method and decrements n, also swaps pegs

                Console.WriteLine("Move Disc from " + a + " to " + b);
                moveDiscs(n - 1, c, b, a);                              // will loop through method until n = 1

            }
        }
    }
}
