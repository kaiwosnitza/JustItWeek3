using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileRiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Can you guess the following riddle?");
            Console.WriteLine("I'm tall when I'm young, I'm short when I'm old. What am I?");

            string response = (Console.ReadLine()).ToLower();
            int numGuesses = 1;

            do
            {
                Console.WriteLine("Try again!");
                Console.WriteLine("I'm tall when I'm young, I'm short when I'm old. What am I?");
                response = Console.ReadLine().ToLower();
                if ((response != "Candle") || (response != "Pencil")) ;
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("I'm tall when I'm young, I'm short when I'm old. What am I?");
                    response = Console.ReadLine().ToLower();
                }
            } while ((response == "Candle") || (response == "Pencil"));
             Console.Write("Well done!");
        }
    }
}
