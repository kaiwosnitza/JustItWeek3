using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this program you will enter numbers to help you guess what the number is");

            int myNum = 7;

            int response = 0;

            Console.Write("Please type a number: ");

            while (response != myNum)

            {
                response = Convert.ToInt32(Console.ReadLine());

                 if (response < myNum)
                {
                    Console.WriteLine("No, the answer is higher than " + response + ".");
                }
                else if (response > myNum)
                {
                    Console.WriteLine("No, the answer is lower than " + response + ".");
                }
            }
            Console.WriteLine("Well done, " + response + " is the correct answer!");
        }
    }
}
