using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int total = 0;

            try
            {
                for (int i = 0; i <= numbers.Length; i++)
                {
                    total += numbers[i];
                    Console.WriteLine(total);
                }
            }
            catch(IndexOutOfRangeException error)
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("the program continues...");

        }
    }
}
