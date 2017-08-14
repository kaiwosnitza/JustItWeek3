using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numsToAdd;
            List<double> Nums = new List<double>() { };
            Console.WriteLine("Welcome.  To add a number, press A; to get the average of all numbers, press V; to list all numbers, press L; to sort all numbers, press S:");
            Console.WriteLine("To exit, press X.");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());
            do
            {
                switch (response)
                {
                    // Add numbers to list
                    case 'A':
                        Console.WriteLine("Please enter a number:");
                        numsToAdd = Convert.ToInt32(Console.ReadLine());
                        Nums.Add(numsToAdd);
                        break;
                    // Get average of numbers
                    case 'V':
                        double total = 0;

                        foreach(double number in Nums)
                        {
                            total += number;
                        }

                        double average = total / (Nums.Count);

                        Console.WriteLine("The average of your numbers is: " + average);
                        break;
                    // Display numbers in list
                    case 'L':
                        for (int i = 0; i < Nums.Count; i++)
                        {            
                            Console.WriteLine(Nums[i]);
                        }
                        break;
                    // Sort numbers in list
                    case 'S':
                        Nums.Sort();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("What would you like to do next: A, V, L, S or X?:");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            // Exit Program
            while (response != 'X');
        }
    }
}
