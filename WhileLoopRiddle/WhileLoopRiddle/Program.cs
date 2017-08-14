using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopRiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Can you guess the following riddle?");
            Console.WriteLine("You can see me in water, but I never get wet. What am I?");

            string response = (Console.ReadLine()).ToLower();
            int numGuesses = 1;
            
            while ((response != "a reflection") && (response != "reflection"))
            {
                numGuesses++;
                Console.WriteLine("Try again!");
                Console.WriteLine("You can see me in water, but I never get wet. What am I?");
                response = Console.ReadLine().ToLower();
            }
            if ((response == "reflection") || (response == "a reflection"))
            {
                Console.Write("Well done!");
            }

            do
            {
                Console.WriteLine("I'm tall when I'm young, I'm short when I'm old. What am I?");
                response = Console.ReadLine().ToLower();
                if ((response != "Candle") || (response != "Pencil"))
                {
                    Console.WriteLine("Try again!");
                }
            } while ((response == "Candle") || (response == "Pencil"));
            Console.WriteLine("Well done!");

        }
    }
}
