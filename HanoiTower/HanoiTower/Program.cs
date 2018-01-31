using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiTower hanoi = new HanoiTower();

            Console.WriteLine("Enter number of discs: ");
            int n = Convert.ToInt32(Console.ReadLine());

            hanoi.moveDiscs(n, "Peg A", "Peg C", "Peg B");  // had to swap Peg B and C...
        }
    }
}
