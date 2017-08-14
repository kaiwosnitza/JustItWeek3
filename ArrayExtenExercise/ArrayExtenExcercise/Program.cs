using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtenExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5];
            Random rand = new Random();

            int[] rowTotals = new int[5];
            int[] columnTotals = new int[5];
            int overallTotal = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = rand.Next(1, 11);
                    Console.Write(numbers[i, j] + "\t");

                    rowTotals[i] += numbers[i, j];
                    columnTotals[j] += numbers[i, j];
                    overallTotal += numbers[i, j];
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rowTotals.Length; i++)
            {
                Console.WriteLine("The total of row " + (i+1) + " is " + rowTotals[i]);
            }
            for (int i = 0; i < columnTotals.Length; i++)
            {
                Console.WriteLine("The total of column " + (i + 1) + " is " + columnTotals[i]);
            }
            Console.WriteLine("The overall total is: " + overallTotal);
        }
    }
}
