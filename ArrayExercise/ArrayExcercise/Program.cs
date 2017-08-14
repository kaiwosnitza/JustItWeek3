using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            double total = 0;

            Console.WriteLine("Please enter 5 numbers");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter 5 numbers");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                total += numbers[i];
            }

            Console.WriteLine("Thank you for entering 5 numbers");
            Console.WriteLine();

            double average = total / (numbers.Length);

            Console.WriteLine("The average of your 5 numbers is: " + average);
        }
    }
}
