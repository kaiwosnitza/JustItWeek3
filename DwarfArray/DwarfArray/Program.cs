using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine("Here's your dinner, " + sevenDwarves[i]);
            }
            foreach (string i in sevenDwarves)
            {
                Console.WriteLine("And here's a nice warm drink, " + i);
            }
        }
    }
}
