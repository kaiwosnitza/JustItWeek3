using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The candidates for the 2016 Presidential election were Donald, Hillary, Bernie, Ted. Who do you think should have won?");
            string userCandidate = Console.ReadLine();

            //string[] name;
            //name = new string("Donald", "Hillary", "Bernie", "Ted");

            switch (userCandidate)
            {
                case "donald":
                    Console.Write("You serious?\n");
                    break;

                case "hillary":
                    Console.Write("Another crook in the whitehouse...\n");
                    break;
                case "bernie":
                    Console.Write("Yeah alright.\n");
                    break;
                case "ted":
                    Console.Write("Who is that guy?\n");
                    break;
                default:
                    Console.Write("Not on the list. \nPlease try again ....\n");
                    break;
            }
        }
    }
}
